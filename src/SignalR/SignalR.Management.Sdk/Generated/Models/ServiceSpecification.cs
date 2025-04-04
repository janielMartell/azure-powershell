// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.SignalR.Models
{
    using System.Linq;

    /// <summary>
    /// An object that describes a specification.
    /// </summary>
    public partial class ServiceSpecification
    {
        /// <summary>
        /// Initializes a new instance of the ServiceSpecification class.
        /// </summary>
        public ServiceSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceSpecification class.
        /// </summary>

        /// <param name="metricSpecifications">Specifications of the Metrics for Azure Monitoring.
        /// </param>

        /// <param name="logSpecifications">Specifications of the Logs for Azure Monitoring.
        /// </param>
        public ServiceSpecification(System.Collections.Generic.IList<MetricSpecification> metricSpecifications = default(System.Collections.Generic.IList<MetricSpecification>), System.Collections.Generic.IList<LogSpecification> logSpecifications = default(System.Collections.Generic.IList<LogSpecification>))

        {
            this.MetricSpecifications = metricSpecifications;
            this.LogSpecifications = logSpecifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets specifications of the Metrics for Azure Monitoring.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metricSpecifications")]
        public System.Collections.Generic.IList<MetricSpecification> MetricSpecifications {get; set; }

        /// <summary>
        /// Gets or sets specifications of the Logs for Azure Monitoring.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "logSpecifications")]
        public System.Collections.Generic.IList<LogSpecification> LogSpecifications {get; set; }
    }
}