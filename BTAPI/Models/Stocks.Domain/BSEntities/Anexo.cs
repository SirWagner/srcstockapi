using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities
{
    public class Anexo : INetcoreBasic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(20)]
        public string Tabela { get; set; }

        [StringLength(50)]
        public string Referencia { get; set; } //chave na tabela

        [StringLength(50)]
        public string FicheiroOrig { get; set; }

        [StringLength(150)]
        public string Descricao { get; set; }

        [StringLength(2)]
        public string Idioma { get; set; }

        public bool Encriptado { get; set; }

        public bool Zipado { get; set; }

        public DateTime? DataCriacao { get; set; }

        public DateTime? DataUltimaActualizacao { get; set; }

        public string Utilizador { get; set; }
    }

}
