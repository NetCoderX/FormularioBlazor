using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAutogestion_Legajos
{
    public int IdLegajo { get; set; }

    public int IdPersona { get; set; }

    public string LegajoCodigo { get; set; } = null!;

    public string? Empresa { get; set; }

    public string? Categoria { get; set; }

    public string? Convenio { get; set; }

    public string Estado { get; set; } = null!;

    public string? FechaAntiguedad { get; set; }

    public string? FechaIngreso { get; set; }

    public string? FechaIndemnizacion { get; set; }

    public string? FechaEgreso { get; set; }

    public string? FechaJubilacion { get; set; }

    public string? ModContratacion { get; set; }

    public string? Regimen { get; set; }

    public string? ZonaGeografica { get; set; }

    public string? Telefono_Directo { get; set; }

    public string? Telefono_Interno { get; set; }

    public string? LugarDeTrabajo { get; set; }

    public string? Banco { get; set; }

    public string BancoCBU { get; set; } = null!;

    public string? ObraSocial { get; set; }
}
