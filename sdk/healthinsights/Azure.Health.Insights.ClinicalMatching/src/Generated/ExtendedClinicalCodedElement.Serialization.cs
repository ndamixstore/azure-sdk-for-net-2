// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class ExtendedClinicalCodedElement
    {
        internal static ExtendedClinicalCodedElement DeserializeExtendedClinicalCodedElement(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string system = default;
            string code = default;
            Optional<string> name = default;
            Optional<string> value = default;
            Optional<string> semanticType = default;
            Optional<string> category = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("system"u8))
                {
                    system = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("semanticType"u8))
                {
                    semanticType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
            }
            return new ExtendedClinicalCodedElement(system, code, name, value, semanticType, category);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ExtendedClinicalCodedElement FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeExtendedClinicalCodedElement(document.RootElement);
        }
    }
}
