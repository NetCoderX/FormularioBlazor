using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_ESTADOSCIVILES
{
    public int IdEstado { get; set; }

    public byte NroEstado { get; set; }

    public string Denominacion { get; set; } = null!;

    public virtual ICollection<BL_PERSONAS> BL_PERSONAS { get; set; } = new List<BL_PERSONAS>();
}
