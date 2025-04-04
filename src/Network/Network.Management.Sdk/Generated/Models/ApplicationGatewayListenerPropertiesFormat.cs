// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of listener of an application gateway.
    /// </summary>
    public partial class ApplicationGatewayListenerPropertiesFormat
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayListenerPropertiesFormat class.
        /// </summary>
        public ApplicationGatewayListenerPropertiesFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayListenerPropertiesFormat class.
        /// </summary>

        /// <param name="frontendIPConfiguration">Frontend IP configuration resource of an application gateway.
        /// </param>

        /// <param name="frontendPort">Frontend port resource of an application gateway.
        /// </param>

        /// <param name="protocol">Protocol of the listener.
        /// Possible values include: &#39;Http&#39;, &#39;Https&#39;, &#39;Tcp&#39;, &#39;Tls&#39;</param>

        /// <param name="sslCertificate">SSL certificate resource of an application gateway.
        /// </param>

        /// <param name="sslProfile">SSL profile resource of the application gateway.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the listener resource.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>

        /// <param name="hostNames">List of Server Name Indications(SNI) for TLS Multi-site Listener that
        /// allows special wildcard characters as well.
        /// </param>
        public ApplicationGatewayListenerPropertiesFormat(SubResource frontendIPConfiguration = default(SubResource), SubResource frontendPort = default(SubResource), string protocol = default(string), SubResource sslCertificate = default(SubResource), SubResource sslProfile = default(SubResource), string provisioningState = default(string), System.Collections.Generic.IList<string> hostNames = default(System.Collections.Generic.IList<string>))

        {
            this.FrontendIPConfiguration = frontendIPConfiguration;
            this.FrontendPort = frontendPort;
            this.Protocol = protocol;
            this.SslCertificate = sslCertificate;
            this.SslProfile = sslProfile;
            this.ProvisioningState = provisioningState;
            this.HostNames = hostNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets frontend IP configuration resource of an application gateway.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "frontendIPConfiguration")]
        public SubResource FrontendIPConfiguration {get; set; }

        /// <summary>
        /// Gets or sets frontend port resource of an application gateway.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "frontendPort")]
        public SubResource FrontendPort {get; set; }

        /// <summary>
        /// Gets or sets protocol of the listener. Possible values include: &#39;Http&#39;, &#39;Https&#39;, &#39;Tcp&#39;, &#39;Tls&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protocol")]
        public string Protocol {get; set; }

        /// <summary>
        /// Gets or sets sSL certificate resource of an application gateway.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sslCertificate")]
        public SubResource SslCertificate {get; set; }

        /// <summary>
        /// Gets or sets sSL profile resource of the application gateway.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sslProfile")]
        public SubResource SslProfile {get; set; }

        /// <summary>
        /// Gets the provisioning state of the listener resource. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets list of Server Name Indications(SNI) for TLS Multi-site
        /// Listener that allows special wildcard characters as well.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "hostNames")]
        public System.Collections.Generic.IList<string> HostNames {get; set; }
    }
}