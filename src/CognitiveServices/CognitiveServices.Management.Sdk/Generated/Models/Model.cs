// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System.Linq;

    /// <summary>
    /// Cognitive Services Model.
    /// </summary>
    public partial class Model
    {
        /// <summary>
        /// Initializes a new instance of the Model class.
        /// </summary>
        public Model()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Model class.
        /// </summary>

        /// <param name="modelProperty">Cognitive Services account Model.
        /// </param>

        /// <param name="kind">The kind (type) of cognitive service account.
        /// </param>

        /// <param name="skuName">The name of SKU.
        /// </param>

        /// <param name="description">The description of the model.
        /// </param>
        public Model(AccountModel modelProperty = default(AccountModel), string kind = default(string), string skuName = default(string), string description = default(string))

        {
            this.ModelProperty = modelProperty;
            this.Kind = kind;
            this.SkuName = skuName;
            this.Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets cognitive Services account Model.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "model")]
        public AccountModel ModelProperty {get; set; }

        /// <summary>
        /// Gets or sets the kind (type) of cognitive service account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kind")]
        public string Kind {get; set; }

        /// <summary>
        /// Gets or sets the name of SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "skuName")]
        public string SkuName {get; set; }

        /// <summary>
        /// Gets or sets the description of the model.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }
    }
}