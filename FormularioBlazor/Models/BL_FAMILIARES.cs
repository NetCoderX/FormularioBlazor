using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_FAMILIARES
{
    public int IdFamiliar { get; set; }

    public int Secuencia { get; set; }

    public string? Apellido { get; set; }

    public string? Nombres { get; set; }

    public string? ApellidoCasada { get; set; }

    public string? CUIL { get; set; }

    public DateTime? FecNacimiento { get; set; }

    public DateTime? FecACargo { get; set; }

    public bool Discapacidad { get; set; }

    public string? DocNro { get; set; }

    public int? IdEstado { get; set; }

    public int IdParentesco { get; set; }

    public int? IdEscolaridad { get; set; }

    public string? AnioEnCurso { get; set; }

    public int? IdNacionalidad { get; set; }

    public bool GeneraDerAF { get; set; }

    public string? DomicilioCalle { get; set; }

    public string? DomicilioNro { get; set; }

    public string? DomicilioPiso { get; set; }

    public string? DomicilioDepto { get; set; }

    public string? DomicilioLoc { get; set; }

    public string? DomicilioCodPos { get; set; }

    public int? IdProvincia { get; set; }

    public string? Observaciones { get; set; }

    public string? CodigoBaja { get; set; }

    public byte[]? Timestamp { get; set; }

    public string TipoVencAsigFam { get; set; } = null!;

    public short? AniosVencAsigFam { get; set; }

    public bool GeneraDeducGan { get; set; }

    public string TipoVencDeducGan { get; set; } = null!;

    public short? AniosVencDeducGan { get; set; }

    public int IdPersona { get; set; }

    public string? CodDoc { get; set; }

    public DateTime? FecVencDeducGan { get; set; }

    public bool RequiereNovedadGan { get; set; }

    public string TipoVencObraSoc { get; set; } = null!;

    public short? AniosVencObraSoc { get; set; }

    public bool AdhiereObraSoc { get; set; }

    public short? ParentescoSIRADIG { get; set; }

    public string? ParentescoSIRADIGDesc { get; set; }

    public bool Inactivo { get; set; }

    public bool AfectaSIRADIG { get; set; }

    public string? Sexo { get; set; }

    public virtual TIPODOC? CodDocNavigation { get; set; }

    public virtual BL_ESCOLARIDADES? IdEscolaridadNavigation { get; set; }

    public virtual BL_NACIONALIDADES? IdNacionalidadNavigation { get; set; }

    public virtual BL_PARENTESCOS IdParentescoNavigation { get; set; } = null!;

    public virtual BL_PERSONAS IdPersonaNavigation { get; set; } = null!;

    public virtual BL_PROVINCIAS? IdProvinciaNavigation { get; set; }
}
