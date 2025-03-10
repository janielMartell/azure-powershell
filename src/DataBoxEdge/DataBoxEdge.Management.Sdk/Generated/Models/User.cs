// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using System.Linq;

    /// <summary>
    /// Represents a user who has access to one or more shares on the Data Box
    /// Edge/Gateway device.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class User : ARMBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>

        /// <param name="id">The path ID that uniquely identifies the object.
        /// </param>

        /// <param name="name">The object name.
        /// </param>

        /// <param name="type">The hierarchical type of the object.
        /// </param>

        /// <param name="userType">Type of the user.
        /// Possible values include: &#39;Share&#39;, &#39;LocalManagement&#39;, &#39;ARM&#39;</param>

        /// <param name="encryptedPassword">The password details.
        /// </param>

        /// <param name="shareAccessRights">List of shares that the user has rights on. This field should not be
        /// specified during user creation.
        /// </param>
        public User(string userType, string id = default(string), string name = default(string), string type = default(string), AsymmetricEncryptedSecret encryptedPassword = default(AsymmetricEncryptedSecret), System.Collections.Generic.IList<ShareAccessRight> shareAccessRights = default(System.Collections.Generic.IList<ShareAccessRight>))

        : base(id, name, type)
        {
            this.UserType = userType;
            this.EncryptedPassword = encryptedPassword;
            this.ShareAccessRights = shareAccessRights;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets type of the user. Possible values include: &#39;Share&#39;, &#39;LocalManagement&#39;, &#39;ARM&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.userType")]
        public string UserType {get; set; }

        /// <summary>
        /// Gets or sets the password details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.encryptedPassword")]
        public AsymmetricEncryptedSecret EncryptedPassword {get; set; }

        /// <summary>
        /// Gets or sets list of shares that the user has rights on. This field should
        /// not be specified during user creation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.shareAccessRights")]
        public System.Collections.Generic.IList<ShareAccessRight> ShareAccessRights {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.UserType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "UserType");
            }

            if (this.EncryptedPassword != null)
            {
                this.EncryptedPassword.Validate();
            }
            if (this.ShareAccessRights != null)
            {
                foreach (var element in this.ShareAccessRights)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}