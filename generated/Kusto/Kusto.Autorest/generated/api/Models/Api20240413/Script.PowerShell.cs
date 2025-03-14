// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413
{
    using Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.PowerShell;

    /// <summary>Class representing a database script.</summary>
    [System.ComponentModel.TypeConverter(typeof(ScriptTypeConverter))]
    public partial class Script
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.Script"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScript" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScript DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Script(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.Script"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScript" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScript DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Script(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Script" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Script" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScript FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.Script"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Script(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ScriptPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Level"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Level = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ScriptLevel?) content.GetValueForProperty("Level",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Level, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ScriptLevel.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Url"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Url = (string) content.GetValueForProperty("Url",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Url, global::System.Convert.ToString);
            }
            if (content.Contains("UrlSasToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).UrlSasToken = (string) content.GetValueForProperty("UrlSasToken",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).UrlSasToken, global::System.Convert.ToString);
            }
            if (content.Contains("Content"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Content = (string) content.GetValueForProperty("Content",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Content, global::System.Convert.ToString);
            }
            if (content.Contains("ForceUpdateTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).ForceUpdateTag = (string) content.GetValueForProperty("ForceUpdateTag",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).ForceUpdateTag, global::System.Convert.ToString);
            }
            if (content.Contains("ContinueOnError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).ContinueOnError = (bool?) content.GetValueForProperty("ContinueOnError",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).ContinueOnError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PrincipalPermissionsAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).PrincipalPermissionsAction = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalPermissionsAction?) content.GetValueForProperty("PrincipalPermissionsAction",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).PrincipalPermissionsAction, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalPermissionsAction.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.Script"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Script(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ScriptPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Level"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Level = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ScriptLevel?) content.GetValueForProperty("Level",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Level, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ScriptLevel.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Url"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Url = (string) content.GetValueForProperty("Url",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Url, global::System.Convert.ToString);
            }
            if (content.Contains("UrlSasToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).UrlSasToken = (string) content.GetValueForProperty("UrlSasToken",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).UrlSasToken, global::System.Convert.ToString);
            }
            if (content.Contains("Content"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Content = (string) content.GetValueForProperty("Content",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).Content, global::System.Convert.ToString);
            }
            if (content.Contains("ForceUpdateTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).ForceUpdateTag = (string) content.GetValueForProperty("ForceUpdateTag",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).ForceUpdateTag, global::System.Convert.ToString);
            }
            if (content.Contains("ContinueOnError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).ContinueOnError = (bool?) content.GetValueForProperty("ContinueOnError",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).ContinueOnError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PrincipalPermissionsAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).PrincipalPermissionsAction = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalPermissionsAction?) content.GetValueForProperty("PrincipalPermissionsAction",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).PrincipalPermissionsAction, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.PrincipalPermissionsAction.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IScriptInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Class representing a database script.
    [System.ComponentModel.TypeConverter(typeof(ScriptTypeConverter))]
    public partial interface IScript

    {

    }
}