using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_PlanesFormularios
{
    public int IdPlanEva { get; set; }

    public int IdEvaluacion { get; set; }

    public int IdFormulario { get; set; }

    public string? EvaluadosPersonas { get; set; }

    public string? EvaluadoresPersonas { get; set; }

    public string? ResponsablesPersonas { get; set; }

    public int IdFormularioDetalle { get; set; }

    public virtual RH_Evaluaciones IdEvaluacionNavigation { get; set; } = null!;

    public virtual RH_Formularios IdFormularioNavigation { get; set; } = null!;
}
