using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RHV_EvaluacionesDePlan
{
    public int? IdEvaluacion { get; set; }

    public string? CodigoEva { get; set; }

    public string? DescripcionEva { get; set; }

    public int IdPlanEva { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? EvaluadosPersonas { get; set; }
}
