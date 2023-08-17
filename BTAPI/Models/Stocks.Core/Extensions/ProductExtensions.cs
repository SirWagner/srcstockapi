
using Stocks.Domain.BSEntities.Base;
using System.Threading.Tasks;

namespace Stocks.Core.Extensions
{
    public static class ProductExtensions
    {
        public static async Task<Artigo> PrepareModelToUpdate(this Artigo productToUpdate, Artigo data)
    {
        if (productToUpdate.IdEstado != data.IdEstado)
        {
            throw new ArgumentException("The 'Id' of the 'data' object must match the 'productToUpdate' object.");
        }

        // Update properties based on the existing product
        if (!string.IsNullOrWhiteSpace(data.Descricao) && data.Descricao != productToUpdate.Descricao)
            productToUpdate.Descricao = data.Descricao;

        if (!string.IsNullOrWhiteSpace(data.CodBarras) && data.CodBarras != productToUpdate.CodBarras)
            productToUpdate.CodBarras = data.CodBarras;

        if (data.IdEstado != 0 && data.IdEstado != productToUpdate.IdEstado)
            productToUpdate.IdEstado = data.IdEstado;

        if (!string.IsNullOrWhiteSpace(data.IdFornecedor) && data.IdFornecedor != productToUpdate.IdFornecedor)
            productToUpdate.IdFornecedor = data.IdFornecedor;

        if (!string.IsNullOrWhiteSpace(data.TipoArtigo) && data.TipoArtigo != productToUpdate.TipoArtigo)
            productToUpdate.TipoArtigo = data.TipoArtigo;

        if (data.StkActual != 0 && data.StkActual != productToUpdate.StkActual)
            productToUpdate.StkActual = data.StkActual;

        return productToUpdate;
    }

    }
}

