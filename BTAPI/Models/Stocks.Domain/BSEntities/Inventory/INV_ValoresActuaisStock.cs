using Stocks.Domain.BSEntities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Inventory
{
    public class INV_ValoresActuaisStock
    {
        [Key]
        public Guid id { get; set; }

        [StringLength(48)]
        [Display(Name = "Artigo")]
        public string artigo { get; set; }

        [StringLength(38)]
        [Display(Name = "Armazem")]
        public string armazem { get; set; }

        [StringLength(20)]
        [Display(Name = "Localização")]
        public string localizacao { get; set; }

        [StringLength(10)]
        [Display(Name = "Lote")]
        public string lote { get; set; }

        [StringLength(10)]
        [Display(Name = "Estado Stock")]
        public string estadoStock { get; set; } //DISP,RES

        [Display(Name = "Stock")]
        public double stock { get; set; }

        [Display(Name = "Data Stock")]
        public DateTime dataStock { get; set; }

        public Guid idMovimentoStock { get; set; }

        [Display(Name = "Bloqueado")]
        public bool bloqueado { get; set; }

        [ForeignKey("idMovimentoStock")]
        public INV_Movimentos INV_Movimentos { get; set; }

        [ForeignKey("armazem")]
        public Armazem Armazem { get; set; }

        [ForeignKey("artigo")]
        public Artigo Artigo { get; set; }

        [ForeignKey("localizacao")]
        public ArmazemLocalizacoes Localizacao { get; set; }
    }
}
