using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_ESCOLARIDADES
{
    public int IdEscolaridad { get; set; }

    public string CodEscolaridad { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<BL_FAMILIARES> BL_FAMILIARES { get; set; } = new List<BL_FAMILIARES>();
}
