// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Storage.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.PowerShell;

    /// <summary>
    /// The replication policy between two storage accounts. Multiple rules can be defined in one policy.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ObjectReplicationPolicyTypeConverter))]
    public partial class ObjectReplicationPolicy
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ObjectReplicationPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicy DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ObjectReplicationPolicy(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ObjectReplicationPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicy DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ObjectReplicationPolicy(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ObjectReplicationPolicy" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ObjectReplicationPolicy" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicy FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ObjectReplicationPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ObjectReplicationPolicy(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ObjectReplicationPolicyPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Metric"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).Metric = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyPropertiesMetrics) content.GetValueForProperty("Metric",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).Metric, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ObjectReplicationPolicyPropertiesMetricsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).PolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("EnabledTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).EnabledTime = (global::System.DateTime?) content.GetValueForProperty("EnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).EnabledTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SourceAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).SourceAccount = (string) content.GetValueForProperty("SourceAccount",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).SourceAccount, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).DestinationAccount = (string) content.GetValueForProperty("DestinationAccount",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).DestinationAccount, global::System.Convert.ToString);
            }
            if (content.Contains("Rule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).Rule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyRule>) content.GetValueForProperty("Rule",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).Rule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ObjectReplicationPolicyRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("MetricEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).MetricEnabled = (bool?) content.GetValueForProperty("MetricEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).MetricEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ObjectReplicationPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ObjectReplicationPolicy(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ObjectReplicationPolicyPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Metric"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).Metric = (Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyPropertiesMetrics) content.GetValueForProperty("Metric",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).Metric, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ObjectReplicationPolicyPropertiesMetricsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).PolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("EnabledTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).EnabledTime = (global::System.DateTime?) content.GetValueForProperty("EnabledTime",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).EnabledTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SourceAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).SourceAccount = (string) content.GetValueForProperty("SourceAccount",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).SourceAccount, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).DestinationAccount = (string) content.GetValueForProperty("DestinationAccount",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).DestinationAccount, global::System.Convert.ToString);
            }
            if (content.Contains("Rule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).Rule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyRule>) content.GetValueForProperty("Rule",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).Rule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.ObjectReplicationPolicyRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("MetricEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).MetricEnabled = (bool?) content.GetValueForProperty("MetricEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IObjectReplicationPolicyInternal)this).MetricEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The replication policy between two storage accounts. Multiple rules can be defined in one policy.
    [System.ComponentModel.TypeConverter(typeof(ObjectReplicationPolicyTypeConverter))]
    public partial interface IObjectReplicationPolicy

    {

    }
}