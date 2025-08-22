using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Serilog;
using Serilog.Events;

namespace Sentinel.Common.Helpers;

public static class LogHelper
{
    public const string LogTemplate =
        "[{Timestamp:yyyy-MM-dd HH:mm:ss}][{Level:u3}][{SourceContext}] {Message:lj}{NewLine}{Exception}";

    private static ILogger? _logger;

    private static readonly List<(
        LogEventLevel Level,
        string MessageTemplate,
        object?[] Args,
        Exception? Exception
    )> LogCache = [];

    public static void Initialize()
    {
        if (_logger != null)
            return;

        Log.Logger = new LoggerConfiguration()
            .WriteTo.Async(c => c.Console(outputTemplate: LogTemplate))
            .WriteTo.Async(c =>
                c.File(
                    PathHelper.LogPath,
                    rollOnFileSizeLimit: true,
                    shared: true,
                    outputTemplate: LogTemplate,
                    rollingInterval: RollingInterval.Day
                )
            )
            .Enrich.FromLogContext()
            .CreateLogger();

        _logger = Log.ForContext("SourceContext", "App");

        FlushCache();
    }

    private static void FlushCache()
    {
        if (_logger == null)
            return;

        foreach (var (level, messageTemplate, args, exception) in LogCache)
        {
            switch (level)
            {
                case LogEventLevel.Information:
                    _logger.Information(exception, messageTemplate, args);
                    break;
                case LogEventLevel.Error:
                    _logger.Error(exception, messageTemplate, args);
                    break;
                case LogEventLevel.Warning:
                    _logger.Warning(exception, messageTemplate, args);
                    break;
                case LogEventLevel.Verbose:
                    _logger.Verbose(exception, messageTemplate, args);
                    break;
                case LogEventLevel.Debug:
                    _logger.Debug(exception, messageTemplate, args);
                    break;
                case LogEventLevel.Fatal:
                    _logger.Fatal(exception, messageTemplate, args);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        LogCache.Clear();
    }

    public static void Information(
        [StructuredMessageTemplate] string messageTemplate,
        params object?[] args
    )
    {
        if (_logger == null)
        {
            LogCache.Add((LogEventLevel.Information, messageTemplate, args, null));
        }
        else
        {
            _logger.Information(messageTemplate, args);
        }
    }

    public static void Error(
        [StructuredMessageTemplate] string messageTemplate,
        params object?[] args
    )
    {
        if (_logger == null)
        {
            LogCache.Add((LogEventLevel.Error, messageTemplate, [], null));
        }
        else
        {
            _logger.Error(messageTemplate, args);
        }
    }

    public static void Error(
        Exception e,
        [StructuredMessageTemplate] string messageTemplate,
        params object?[] args
    )
    {
        if (_logger == null)
        {
            LogCache.Add((LogEventLevel.Error, messageTemplate, args, e));
        }
        else
        {
            _logger.Error(e, messageTemplate, args);
        }
    }

    public static void Warning(
        [StructuredMessageTemplate] string messageTemplate,
        params object[] args
    )
    {
        if (_logger == null)
        {
            LogCache.Add((LogEventLevel.Warning, messageTemplate, args, null));
        }
        else
        {
            _logger.Warning(messageTemplate, args);
        }
    }
}
