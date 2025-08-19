using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_CapacitacionesEvaluaciones
{
    public int IdCapacitacion { get; set; }

    public int IdEvaluacion { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual RH_Capacitaciones IdCapacitacionNavigation { get; set; } = null!;

    public virtual RH_Evaluaciones IdEvaluacionNavigation { get; set; } = null!;
}
