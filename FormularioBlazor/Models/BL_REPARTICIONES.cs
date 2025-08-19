using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_REPARTICIONES
{
    public int IdReparticion { get; set; }

    public string CodReparticion { get; set; } = null!;

    public string Denominacion { get; set; } = null!;

    public string? NroInscrEmpresa { get; set; }

    public string Tipo { get; set; } = null!;

    public byte CtaBancoAlternativa { get; set; }

    public string? DomicilioCalle { get; set; }

    public string? DomicilioNro { get; set; }

    public string? DomicilioPiso { get; set; }

    public string? DomicilioDepto { get; set; }

    public string? DomicilioLoc { get; set; }

    public string? DomicilioCodPos { get; set; }

    public int? idProvincia { get; set; }

    public string? Telefono { get; set; }

    public string? Fax { get; set; }

    public string? Contacto { get; set; }

    public string? EMail { get; set; }

    public string? PaginaWeb { get; set; }

    public byte? TipoOS { get; set; }

    public virtual ICollection<BL_RECIBOS> BL_RECIBOS { get; set; } = new List<BL_RECIBOS>();
}
