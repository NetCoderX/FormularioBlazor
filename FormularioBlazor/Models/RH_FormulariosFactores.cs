using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_FormulariosFactores
{
    public int IdFormulario { get; set; }

    public int IdFactor { get; set; }

    public string? Descripcion { get; set; }

    public double? Ponderacion { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual RH_Factores IdFactorNavigation { get; set; } = null!;

    public virtual RH_Formularios IdFormularioNavigation { get; set; } = null!;
}
