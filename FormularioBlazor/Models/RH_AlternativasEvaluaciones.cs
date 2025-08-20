using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_AlternativasEvaluaciones
{
    public int IdAlternativa { get; set; }

    public int IdHabilidad { get; set; }

    public int IdEvaluacion { get; set; }

    public virtual RH_Evaluaciones IdEvaluacionNavigation { get; set; } = null!;

    public virtual RH_Habilidades IdHabilidadNavigation { get; set; } = null!;
}
