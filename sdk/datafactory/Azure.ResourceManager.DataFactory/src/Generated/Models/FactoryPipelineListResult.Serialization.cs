// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class FactoryPipelineListResult
    {
        internal static FactoryPipelineListResult DeserializeFactoryPipelineListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<FactoryPipelineData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<FactoryPipelineData> array = new List<FactoryPipelineData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FactoryPipelineData.DeserializeFactoryPipelineData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new FactoryPipelineListResult(value, nextLink.Value);
        }
    }
}
