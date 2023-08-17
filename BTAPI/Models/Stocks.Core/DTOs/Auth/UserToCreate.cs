using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Core.DTOs.Auth
{
    public class UserToCreate
    {
        public int Id { get; set; }
        [Required]
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("phone_number_1")]
        public string PhoneNumber1 { get; set; }
        [JsonProperty("phone_number_2")]
        public string PhoneNumber2 { get; set; }
        [Required]
        [JsonProperty("email")]
        public string Email { get; set; }
        [Required]
        [StringLength(14, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 14.")]
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("confirm_password")]
        public string ConfirmPassword { get; set; }

        [NotMapped] // This property will not be mapped to the database
        public string PasswordHash { get; set; }
    }
}
