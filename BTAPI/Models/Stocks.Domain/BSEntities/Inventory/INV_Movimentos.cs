using Stocks.Domain.BSEntities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Domain.BSEntities.Inventory
{
    public class INV_Movimentos : INetcoreBasic
    {
        [Key]
        public Guid Id { get; set; }

        public int IdOrigem { get; set; }

        public DateTime Data { get; set; }

        public DateTime DataIntegracao { get; set; }

        public int NumRegisto { get; set; }

        public bool PeriodoFechado { get; set; }

        public string Artigo { get; set; }

        public string Armazem { get; set; }

        public string Localizacao { get; set; }

        public string Lote { get; set; }

        public bool EstadoStock { get; set; }

        public string TipoMovimento { get; set; } //S;E;I

        public double Quantidade { get; set; }

        public double Stock_Anterior { get; set; }

        public double Stock_Actual { get; set; }

        public double StockLot_Anterior { get; set; }

        public double StockLot_Actual { get; set; }

        public double StockArm_Anterior { get; set; }

        public double StockArm_Actual { get; set; }

        public double StockArmLot_Anterior { get; set; }

        public double StockArmLot_Actual { get; set; }

        public double StockLoc_Anterior { get; set; }

        public double StockLoc_Actual { get; set; }

        public double StockLocLot_Anterior { get; set; }

        public double StockLocLot_Actual { get; set; }

        public double Existencias_Anterior { get; set; }

        public double Existencias_Actual { get; set; }

        public double ExistenciasLot_Anterior { get; set; }

        public double ExistenciasLot_Actual { get; set; }

        public double ExistenciasArm_Anterior { get; set; }

        public double ExistenciasArm_Actual { get; set; }

        public double ExistenciasArmLot_Anterior { get; set; }

        public double ExistenciasArmLot_Actual { get; set; }

        public double ExistenciasLoc_Anterior { get; set; }

        public double ExistenciasLoc_Actual { get; set; }

        public double ExistenciasLocLot_Anterior { get; set; }

        public double ExistenciasLocLot_Actual { get; set; }

        public string IdReserva { get; set; }

        public bool Sistema { get; set; }

        public bool Calculado { get; set; }

        public double ExistenciasGrpCst_Actual { get; set; }

        public double ExistenciasGrpCst_Anterior { get; set; }

        public double ExistenciasGrpCstLot_Actual { get; set; }

        public double ExistenciasGrpCstLot_Anterior { get; set; }

        [ForeignKey("Armazem")]
        public Armazem _Armazem { get; set; }

        [ForeignKey("Localizacao")]
        public ArmazemLocalizacoes _Localizacao { get; set; }

        [ForeignKey("Artigo")]
        public Artigo _Artigo { get; set; }
        public DateTime? DataCriacao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DataUltimaActualizacao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Utilizador { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
