using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_PARENTESCOS
{
    public int IdParentesco { get; set; }

    public string CodParentesco { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Tipo { get; set; }

    public short EdadAsigFam { get; set; }

    public short EdadGanancias { get; set; }

    public bool GuardaTutela { get; set; }

    public virtual ICollection<BL_FAMILIARES> BL_FAMILIARES { get; set; } = new List<BL_FAMILIARES>();
}
