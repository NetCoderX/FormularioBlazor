using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_EvaluacionesFormularios
{
    public int IdEvaluacion { get; set; }

    public int IdFormulario { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual RH_Evaluaciones IdEvaluacionNavigation { get; set; } = null!;

    public virtual RH_Formularios IdFormularioNavigation { get; set; } = null!;
}
