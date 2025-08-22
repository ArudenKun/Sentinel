using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sentinel.Common.JsonConverters;

public class CultureInfoJsonConverter : JsonConverter<CultureInfo>
{
    public override CultureInfo? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return CultureInfo.GetCultureInfo(reader.GetString() ?? "en-US");
    }

    public override void Write(
        Utf8JsonWriter writer,
        CultureInfo value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(value.Name);
    }
}
