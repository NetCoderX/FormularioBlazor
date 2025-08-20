using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Formularios_Detalle
{
    public int IdFormulario { get; set; }

    public int IdFormularioDetalle { get; set; }

    public string? Evaluados { get; set; }

    public string? Evaluadores { get; set; }

    public string? Responsables { get; set; }

    public virtual RH_Formularios IdFormularioNavigation { get; set; } = null!;
}
