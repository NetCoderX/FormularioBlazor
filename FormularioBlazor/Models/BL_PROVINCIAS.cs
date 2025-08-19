using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_PROVINCIAS
{
    public int IdProvincia { get; set; }

    public string NroProvincia { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public byte NoExisteEnBASCS { get; set; }

    public virtual ICollection<BL_FAMILIARES> BL_FAMILIARES { get; set; } = new List<BL_FAMILIARES>();

    public virtual ICollection<BL_PERSONAS> BL_PERSONAS { get; set; } = new List<BL_PERSONAS>();
}
