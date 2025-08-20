using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_PlanesEvaluaciones
{
    public int IdPlanEva { get; set; }

    public int IdEvaluacion { get; set; }

    public DateTime? FecEntrega { get; set; }

    public virtual RH_Evaluaciones IdEvaluacionNavigation { get; set; } = null!;
}
