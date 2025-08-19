using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vPBI_Recibos
{
    public string? Clave { get; set; }

    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public int IdPersona { get; set; }

    public string LegajoCodigo { get; set; } = null!;

    public string? Empresa { get; set; }

    public DateTime Liquidacion_Mes { get; set; }

    public string Liquidacion_Codigo { get; set; } = null!;

    public string Liquidacion_Nombre { get; set; } = null!;

    public string? LugarDeTrabajo { get; set; }
}
