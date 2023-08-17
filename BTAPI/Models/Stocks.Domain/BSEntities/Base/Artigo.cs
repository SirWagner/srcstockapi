using Stocks.Domain.BSEntities.Inventory;
using Stocks.Domain.Helpers;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Base
{
    public class Artigo 
    {
        [Key]
        [StringLength(48)]
        [JsonProperty("id")]
        public string Codigo { get; set; }

        [StringLength(50)]
        [JsonProperty("description")]
        public string Descricao { get; set; }
        
        [StringLength(100)]
        [JsonProperty("barcode")] 
        public string CodBarras { get; set; }

        [JsonProperty("Warehouse")]
        public ArtigoArmazem ArtigoArmazem { get; set; }

        [JsonProperty("stock")]
        public double StkActual { get; set; }

        [StringLength(10)]
        [JsonProperty("type")]
        public string TipoArtigo { get; set; }

        [ForeignKey("TipoArtigo")]
        [JsonProperty("Type")]
        public TipoArtigo _TipoArtigo { get; set; }

        [JsonProperty("Unity")]
        public ArtigoUnidades ArtigoUnidades { get; set; }
        
        [JsonIgnore]
        public Collection<Linhas_ArtigoArmazem> Linhas_ArtigoArmazem { get; set; }

        [JsonIgnore]
        public Collection<Linhas_ArtigoUnidades> Linhas_ArtigoUnidades { get; set; }

        [JsonProperty("status_id")]
        public short? IdEstado { get; set; }

        [ForeignKey("IdEstado")]
        [JsonProperty("status")]
        public EstadoArtigo Estado { get; set; }

        [JsonProperty("supplier_id")]
        [StringLength(10)]
        public string IdFornecedor { get; set; }

        [ForeignKey("IdFornecedor")]
        [JsonProperty("supplier")]
        public Fornecedor Fornecedor { get; set; }

        public static string DaEstado(ArtigoEstado estado)
        {
            string output;

            switch (estado)
            {
                case ArtigoEstado.Disponível:
                    output = "Disponível"; break;
                case ArtigoEstado.Danificado:
                    output = "Danificado"; break;
                case ArtigoEstado.Lavandaria:
                    output = "Lavandaria"; break;
                case ArtigoEstado.Reparação:
                    output = "Reparação"; break;
                case ArtigoEstado.Vazio:
                    output = "Vazio"; break;
                case ArtigoEstado.Semi_Cheio:
                    output = "Semi_Cheio"; break;
                case ArtigoEstado.Cheio:
                    output = "Cheio"; break;
                default:
                    output = ""; break;
            }
            return output;
        }
    }
}
