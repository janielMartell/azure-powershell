// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{

    /// <summary>
    /// Defines values for FileServiceUsagesName.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FileServiceUsagesName
    {
        [System.Runtime.Serialization.EnumMember(Value = "default")]
        Default
    }
    internal static class FileServiceUsagesNameEnumExtension
    {
        internal static string ToSerializedValue(this FileServiceUsagesName? value)
        {
            return value == null ? null : ((FileServiceUsagesName)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this FileServiceUsagesName value)
        {
            switch( value )
            {
                case FileServiceUsagesName.Default:
                    return "default";
            }
            return null;
        }
        internal static FileServiceUsagesName? ParseFileServiceUsagesName(this string value)
        {
            switch( value )
            {
                case "default":
                    return FileServiceUsagesName.Default;
            }
            return null;
        }
    }
}