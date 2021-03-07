using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace D.Doc.Server
{
    //public class ObjectToStringConverter : JsonConverter<string>
    //{
    //    public override string Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    //    {
    //        if (reader.TokenType == JsonTokenType.o)
    //        {
    //            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
    //            if (Utf8Parser.TryParse(span, out int number, out int bytesConsumed) && span.Length == bytesConsumed)
    //            {
    //                return number;
    //            }

    //            if (int.TryParse(reader.GetString(), out number))
    //            {
    //                return number;
    //            }
    //        }

    //        return reader.GetInt32();
    //    }

    //    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    //    {
    //        writer.WriteStringValue(value.ToString());
    //    }
    //}
}
