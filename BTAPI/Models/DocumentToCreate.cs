using System;
using System.Collections.Generic;

namespace BTAPI.Models;

public partial class DocumentToCreate
{
    public int Id { get; set; }

    public string? ArmazemOrigem { get; set; }

    public string? LocalizacaoOrigem { get; set; }

    public string? AreaNegocio { get; set; }

    public string? Projecto { get; set; }

    public string? Tipodoc { get; set; }

    public DateTime? Data { get; set; }

    public long? NumDoc { get; set; }

    public string? NrDocExterno { get; set; }

    public string? Serie { get; set; }

    public string? TipoEntidade { get; set; }

    public string? Entidade { get; set; }

    public string? Nome { get; set; }

    public string? Resumo { get; set; }

    public string? Notas { get; set; }

    public string? Anexo { get; set; }

    public DateTime? DataCriacao { get; set; }

    public DateTime? DataUltimaActualizacao { get; set; }

    public string? Utilizador { get; set; }
}
