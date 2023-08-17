using Stocks.Domain.BSEntities.Base;
using Stocks.Domain.BSEntities.Inventory;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Internal
{
    public class LinhaInternoStatus
    {      
        /// <summary>
        /// The Id comes from cabec internos values
        /// </summary>
        [Key]
        public long IdLinhaInterno { get; set; }

        [ForeignKey("IdLinhaInterno")]
        public LinhaInterno LinhaInterno { get; set; }

        public double Quantidade { get; set; }

        public double QuantidadeTransformada { get; set; }

        /// <summary>
        /// Accept statuses are P - Pendente , T - Transformado, F - Fechada, C - Cancelada
        /// </summary>
        public char Estado { get; set; } = LineStatus.Pendente;

        private double quantidadePendente;

        public double QuantidadePendente
        {
            get { return quantidadePendente; }
            set { quantidadePendente = (Quantidade - QuantidadeTransformada); }
        }

        public static class LineStatus
        {
            public const  char Pendente = 'P';
            public const char Transformado = 'T';
            public const char Fechado = 'F';
            public const char Cancelado = 'C';
        }
    }
}
