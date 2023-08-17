using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities
{
    public class Utilizador 
    {
        public int Id { get; set; }

        [StringLength(48)]
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [StringLength(48)]
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [StringLength(38)]
        [JsonProperty("branch_id")]
        public string FilialId { get; set; }

        [ForeignKey("FilialId")]
        [JsonProperty("branch")]
        public Filial Filial { get; set; }

        [StringLength(15)]
        [JsonProperty("phone_number_1")]
        public string PhoneNumber1 { get; set; }

        [StringLength(15)]
        [JsonProperty("phone_number_2")]
        public string PhoneNumber2 { get; set; }

        [StringLength(128)]
        public string Email { get; set; }

        [JsonIgnore]
        public byte[] PasswordHash { get; set; }

        [JsonIgnore]
        public byte[] PasswordSalt { get; set; }
        public IEnumerable<UserRole> Roles { get; set; } = new List<UserRole>();
        public bool? IsDeleted { get; set; } = false;
        public bool? IsSuperAdmin { get; set; } = false;
        public bool? IsAdmin { get; set; } = false;
    }
}
