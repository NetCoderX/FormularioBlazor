using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vReparticionesLegajos2
{
    public int IdLegajo { get; set; }

    public string? ObraSocialCod { get; set; }

    public string? ObraSocialDesc { get; set; }

    public string? TipoObraSocial { get; set; }

    public string? BancoPagoCod { get; set; }

    public string? BancoPagoDesc { get; set; }

    public string? NroInscrLegajo { get; set; }

    public string? CBU { get; set; }
}
