// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceGraph.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for FacetSortOrder.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FacetSortOrder
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }
    internal static class FacetSortOrderEnumExtension
    {
        internal static string ToSerializedValue(this FacetSortOrder? value)
        {
            return value == null ? null : ((FacetSortOrder)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this FacetSortOrder value)
        {
            switch( value )
            {
                case FacetSortOrder.Asc:
                    return "asc";
                case FacetSortOrder.Desc:
                    return "desc";
            }
            return null;
        }

        internal static FacetSortOrder? ParseFacetSortOrder(this string value)
        {
            switch( value )
            {
                case "asc":
                    return FacetSortOrder.Asc;
                case "desc":
                    return FacetSortOrder.Desc;
            }
            return null;
        }
    }
}
