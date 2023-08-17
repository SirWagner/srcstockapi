using Stocks.Domain.BSEntities.Base;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.BSEntities
{
    public class UserRole 
    {
        [Key]
        public int UserId { get; set; }
        [ForeignKey("UserId")]

        [JsonIgnore]
        public Utilizador User { get; set; }
        public short RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}
