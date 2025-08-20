using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_SECURITY_TIPOS
{
    public int IdTipo { get; set; }

    public string DetalleTipo { get; set; } = null!;

    public virtual ICollection<BL_SECURITY_PERMISOS> BL_SECURITY_PERMISOS { get; set; } = new List<BL_SECURITY_PERMISOS>();
}
