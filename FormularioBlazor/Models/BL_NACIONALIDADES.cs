using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_NACIONALIDADES
{
    public int IdNacionalidad { get; set; }

    public short NroNacionalidad { get; set; }

    public string Denominacion { get; set; } = null!;

    public virtual ICollection<BL_FAMILIARES> BL_FAMILIARES { get; set; } = new List<BL_FAMILIARES>();

    public virtual ICollection<BL_PERSONAS> BL_PERSONAS { get; set; } = new List<BL_PERSONAS>();
}
