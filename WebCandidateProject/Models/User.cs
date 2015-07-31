using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WebCandidateProject.Models
{
    public class User
    {
        /// <summary>
        /// Gets or sets the user id
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        [Required(ErrorMessage="The First Name field is required")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the address
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the city
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        [Required]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [Required]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the zip
        /// </summary>
        [JsonProperty(PropertyName = "zip")]
        [Required]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or sets the profile image
        /// </summary>
        [JsonProperty(PropertyName = "profileImage")]
        public string ProfileImage { get; set; }
    }
}