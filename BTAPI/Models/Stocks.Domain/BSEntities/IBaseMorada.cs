using System.ComponentModel.DataAnnotations;

namespace Stocks.Domain.BSEntities
{
    public interface IBaseMorada
    {
        [Display(Name = "Morada 1")]
        [Required]
        [StringLength(50)]
        string Morada1 { get; set; }

        [Display(Name = "Morada 2")]
        [StringLength(50)]
        string Morada2 { get; set; }

        [Display(Name = "Cidade")]
        [StringLength(30)]
        string Cidade { get; set; }

        [Display(Name = "Provincia")]
        [StringLength(30)]
        string Provincia { get; set; }

        [Display(Name = "Pais")]
        [StringLength(30)]
        string Pais { get; set; }
    }
}
