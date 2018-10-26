// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UserProfileResponse
    {
        /// <summary>
        /// Initializes a new instance of the UserProfileResponse class.
        /// </summary>
        public UserProfileResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserProfileResponse class.
        /// </summary>
        /// <param name="id">The unique id (UUID) of the user</param>
        /// <param name="displayName">The full name of the user. Might for
        /// example be first and last name</param>
        /// <param name="email">The email address of the user</param>
        /// <param name="name">The unique name that is used to identify the
        /// user.</param>
        /// <param name="origin">The creation origin of this user. Possible
        /// values include: 'appcenter', 'hockeyapp', 'codepush'</param>
        /// <param name="avatarUrl">The avatar URL of the user</param>
        /// <param name="canChangePassword">User is required to send an old
        /// password in order to change the password.</param>
        /// <param name="permissions">The permissions the user has for the
        /// app</param>
        public UserProfileResponse(System.Guid id, string displayName, string email, string name, string origin, string avatarUrl = default(string), bool? canChangePassword = default(bool?), IList<string> permissions = default(IList<string>))
        {
            Id = id;
            AvatarUrl = avatarUrl;
            CanChangePassword = canChangePassword;
            DisplayName = displayName;
            Email = email;
            Name = name;
            Permissions = permissions;
            Origin = origin;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique id (UUID) of the user
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the avatar URL of the user
        /// </summary>
        [JsonProperty(PropertyName = "avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Gets or sets user is required to send an old password in order to
        /// change the password.
        /// </summary>
        [JsonProperty(PropertyName = "can_change_password")]
        public bool? CanChangePassword { get; set; }

        /// <summary>
        /// Gets or sets the full name of the user. Might for example be first
        /// and last name
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the email address of the user
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the unique name that is used to identify the user.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the permissions the user has for the app
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public IList<string> Permissions { get; set; }

        /// <summary>
        /// Gets or sets the creation origin of this user. Possible values
        /// include: 'appcenter', 'hockeyapp', 'codepush'
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Origin == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Origin");
            }
        }
    }
}