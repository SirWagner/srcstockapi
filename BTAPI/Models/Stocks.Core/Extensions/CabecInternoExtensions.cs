using Stocks.Domain.BSEntities.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Core.Extensions
{
    public static class CabecInternoExtensions
    {
        public async static Task<CabecInterno> PrepareDocToUpdate(this CabecInterno docToUpdate, CabecInterno data)
        {
            if (docToUpdate.Id != data.Id)
            {
                throw new ArgumentException("The 'Id' of the 'data' object must match the 'docToUpdate' object.");
            }
            //Check if Object 
            if (!string.IsNullOrWhiteSpace(data.Anexo) && data.Anexo != docToUpdate.Anexo)
                docToUpdate.Anexo = data.Anexo;

            if (!string.IsNullOrWhiteSpace(data.AreaNegocio) && data.AreaNegocio != docToUpdate.AreaNegocio)
                docToUpdate.AreaNegocio = data.AreaNegocio;

            if (!string.IsNullOrWhiteSpace(data.ArmazemOrigem) && data.ArmazemOrigem != docToUpdate.ArmazemOrigem)
                docToUpdate.ArmazemOrigem = data.ArmazemOrigem;

            if (!(data.Data == null) && docToUpdate.Data != data.Data)
                docToUpdate.Data = data.Data;

            //docToUpdate.DataUltimaActualizacao = DateTime.Now;

            if (!string.IsNullOrWhiteSpace(data.Tipodoc) && data.Tipodoc != docToUpdate.Tipodoc)
                docToUpdate.Tipodoc = data.Tipodoc;

            if (!string.IsNullOrWhiteSpace(data.Entidade) && data.Entidade != docToUpdate.Entidade)
                docToUpdate.Entidade = data.Entidade;

            if (!string.IsNullOrWhiteSpace(data.TipoEntidade) && data.TipoEntidade != docToUpdate.TipoEntidade)
                docToUpdate.TipoEntidade = data.TipoEntidade;

            if (!string.IsNullOrWhiteSpace(data.LocalizacaoOrigem) && data.LocalizacaoOrigem != docToUpdate.LocalizacaoOrigem)
                docToUpdate.LocalizacaoOrigem = data.LocalizacaoOrigem;

            if (!string.IsNullOrWhiteSpace(data.Nome) && data.Nome != docToUpdate.Nome)
                docToUpdate.Nome = data.Nome;

            if (!string.IsNullOrWhiteSpace(data.Notas) && data.Notas != docToUpdate.Notas)
                docToUpdate.Notas = data.Notas;

            if (!string.IsNullOrWhiteSpace(data.NrDocExterno) && data.NrDocExterno != docToUpdate.NrDocExterno)
                docToUpdate.NrDocExterno = data.NrDocExterno;

            //if (!string.IsNullOrWhiteSpace(data.Projeto) && data.Projeto != docToUpdate.Projeto)
            //    docToUpdate.Projeto = data.Projeto;

            if (!string.IsNullOrWhiteSpace(data.Resumo) && data.Resumo != docToUpdate.Resumo)
                docToUpdate.Resumo = data.Resumo;

            if (!string.IsNullOrWhiteSpace(data.Anexo) && data.Anexo != docToUpdate.Anexo)
                docToUpdate.Anexo = data.Anexo;

            if (!string.IsNullOrWhiteSpace(data.PathAnexo) && data.PathAnexo != docToUpdate.PathAnexo)
                docToUpdate.PathAnexo = data.PathAnexo;

            if (!string.IsNullOrWhiteSpace(data.Serie) && data.Serie != docToUpdate.Serie)
                docToUpdate.Serie = data.Serie;

            if (data.Status != 0 && data.Status != docToUpdate.Status)
                docToUpdate.Status = data.Status;

            if (data.NumDoc != 0 && data.NumDoc != docToUpdate.NumDoc)
                docToUpdate.NumDoc = data.NumDoc;
            
            return docToUpdate;
        }

        public static string ValidateModel(this CabecInterno data)
        {
            string resultMsg = string.Empty;

            if (data.Linhas == null || data.Linhas.Count() == 0)
                resultMsg = "The document details are required. Please add and try to save again.";

            return resultMsg;
        }
    }
}
