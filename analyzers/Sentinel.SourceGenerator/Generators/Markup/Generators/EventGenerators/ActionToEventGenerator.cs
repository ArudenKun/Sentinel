using Sentinel.SourceGenerator.Generators.Markup.ExtensionInfos;

namespace Sentinel.SourceGenerator.Generators.Markup.Generators.EventGenerators;

public class ActionToEventGenerator : ExtensionGeneratorBase<EventExtensionInfo>
{
    protected override string GetExtension(EventExtensionInfo @event)
    {
        var eventHandler = @event.EventHandler;
        //var eventParameterTypes = new List<string>() { "global::System.Object?" };

        var argsString =
            $"global::System.Action<{string.Join(", ", @event.EventParameterTypes)}> action";

        // Generate the lambda parameter names (arg0, arg1, etc.)
        var lambdaParameters = string.Join(
            ", ",
            @event.EventParameterTypes.Select((type, index) => $"arg{index}")
        );

        // Generate the action call string
        var actionCallStr = $"action({lambdaParameters})";

        var extensionBody =
            $"        => control._setEvent(({eventHandler})(({lambdaParameters}) => {actionCallStr}), h => control.{@event.EventName} += h);";

        if (@event.IsRoutedEvent)
        {
            argsString += ", global::Avalonia.Interactivity.RoutingStrategies? routes = null";

            extensionBody =
                $"{Helper.NewLine}{{{Helper.NewLine}"
                + $"        => control.AddHandler({@event.ControlTypeName}.{@event.EventName}Event, (_, args) => action(args), routes ?? default(RoutingStrategies));"
                + $"}}{Helper.NewLine}";
        }

        var extensionText =
            (@event.IsObsolete ? "[Obsolete]" + Helper.NewLine : "")
            + $"    public static {@event.ReturnType} {"On" + @event.EventName}{@event.GenericArg}"
            + $"(this {@event.ReturnType} control, {argsString}) {@event.GenericConstraint}{Helper.NewLine}"
            + extensionBody;

        return extensionText;
    }
}
