using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAUDI_FAMILIARES
{
    public int IdFamiliar { get; set; }

    public int IdPersona { get; set; }

    public int? IdEstado { get; set; }

    public int IdParentesco { get; set; }

    public int? IdEscolaridad { get; set; }

    public int? IdNacionalidad { get; set; }

    public int? IdProvincia { get; set; }

    public string? Persona { get; set; }

    public string? Familiar_Nombres { get; set; }

    public string? Familiar_Apellido { get; set; }

    public string? Familiar_Apellido_Casada { get; set; }

    public string? Parentesco { get; set; }

    public string? Escolaridad { get; set; }

    public string? Documento { get; set; }

    public string? CUIL { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Estado_Civil { get; set; }

    public string? Domicilio { get; set; }

    public string? Localidad { get; set; }

    public string? Provincia { get; set; }

    public DateTime? Fecha_de_Nacimiento { get; set; }

    public bool? GuardaTutela { get; set; }

    public bool AdhiereObraSoc { get; set; }

    public string TipoVencObraSoc { get; set; } = null!;

    public short? AniosVencObraSoc { get; set; }

    public bool RequiereNovedadGan { get; set; }

    public DateTime? FecACargo { get; set; }

    public bool Discapacidad { get; set; }

    public string? AnioEnCurso { get; set; }

    public bool GeneraDerAF { get; set; }

    public string TipoVencAsigFam { get; set; } = null!;

    public short? AniosVencAsigFam { get; set; }

    public bool GeneraDeducGan { get; set; }

    public string TipoVencDeducGan { get; set; } = null!;

    public short? AniosVencDeducGan { get; set; }

    public DateTime? FecVencDeducGan { get; set; }

    public string? Observaciones { get; set; }

    public string? CodigoBaja { get; set; }
}
