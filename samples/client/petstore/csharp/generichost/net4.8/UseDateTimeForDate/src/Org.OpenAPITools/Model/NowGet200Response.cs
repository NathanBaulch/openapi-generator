// <auto-generated>
/*
 * OpenAPI Dates
 *
 * This spec contains endpoints with dates in different formats
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// NowGet200Response
    /// </summary>
    public partial class NowGet200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NowGet200Response" /> class.
        /// </summary>
        /// <param name="now">now</param>
        /// <param name="today">today</param>
        [JsonConstructor]
        public NowGet200Response(Option<DateTime?> now = default, Option<DateTime?> today = default)
        {
            NowOption = now;
            TodayOption = today;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Now
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> NowOption { get; private set; }

        /// <summary>
        /// Gets or Sets Now
        /// </summary>
        [JsonPropertyName("now")]
        public DateTime? Now { get { return this.NowOption; } set { this.NowOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of Today
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> TodayOption { get; private set; }

        /// <summary>
        /// Gets or Sets Today
        /// </summary>
        [JsonPropertyName("today")]
        public DateTime? Today { get { return this.TodayOption; } set { this.TodayOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NowGet200Response {\n");
            sb.Append("  Now: ").Append(Now).Append("\n");
            sb.Append("  Today: ").Append(Today).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="NowGet200Response" />
    /// </summary>
    public class NowGet200ResponseJsonConverter : JsonConverter<NowGet200Response>
    {
        /// <summary>
        /// The format to use to serialize Now
        /// </summary>
        public static string NowFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize Today
        /// </summary>
        public static string TodayFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="NowGet200Response" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override NowGet200Response Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime?> now = default;
            Option<DateTime?> today = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "now":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                now = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "today":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                today = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (now.IsSet && now.Value == null)
                throw new ArgumentNullException(nameof(now), "Property is not nullable for class NowGet200Response.");

            if (today.IsSet && today.Value == null)
                throw new ArgumentNullException(nameof(today), "Property is not nullable for class NowGet200Response.");

            return new NowGet200Response(now, today);
        }

        /// <summary>
        /// Serializes a <see cref="NowGet200Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="nowGet200Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, NowGet200Response nowGet200Response, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, nowGet200Response, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="NowGet200Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="nowGet200Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, NowGet200Response nowGet200Response, JsonSerializerOptions jsonSerializerOptions)
        {
            if (nowGet200Response.NowOption.IsSet)
                writer.WriteString("now", nowGet200Response.NowOption.Value.Value.ToString(NowFormat));

            if (nowGet200Response.TodayOption.IsSet)
                writer.WriteString("today", nowGet200Response.TodayOption.Value.Value.ToString(TodayFormat));
        }
    }
}
