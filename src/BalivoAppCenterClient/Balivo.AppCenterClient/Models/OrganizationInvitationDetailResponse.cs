// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OrganizationInvitationDetailResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OrganizationInvitationDetailResponse class.
        /// </summary>
        public OrganizationInvitationDetailResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OrganizationInvitationDetailResponse class.
        /// </summary>
        /// <param name="id">The unique ID (UUID) of the invitation</param>
        /// <param name="email">The email address of the invited user</param>
        /// <param name="isExistingUser">Indicates whether the invited user
        /// already exists</param>
        /// <param name="role">The role assigned to the invited user</param>
        public OrganizationInvitationDetailResponse(System.Guid id, OrganizationResponse organization, string email, UserProfileResponse invitedBy, bool isExistingUser, string role = default(string))
        {
            Id = id;
            Organization = organization;
            Email = email;
            InvitedBy = invitedBy;
            IsExistingUser = isExistingUser;
            Role = role;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique ID (UUID) of the invitation
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public OrganizationResponse Organization { get; set; }

        /// <summary>
        /// Gets or sets the email address of the invited user
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invited_by")]
        public UserProfileResponse InvitedBy { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the invited user already exists
        /// </summary>
        [JsonProperty(PropertyName = "is_existing_user")]
        public bool IsExistingUser { get; set; }

        /// <summary>
        /// Gets or sets the role assigned to the invited user
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Organization == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Organization");
            }
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (InvitedBy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InvitedBy");
            }
            if (Organization != null)
            {
                Organization.Validate();
            }
            if (InvitedBy != null)
            {
                InvitedBy.Validate();
            }
        }
    }
}
