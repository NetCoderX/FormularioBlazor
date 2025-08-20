using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_SECURITY_GRUPOS
{
    public int IdGrupo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<BL_SECURITY_SETEO> BL_SECURITY_SETEO { get; set; } = new List<BL_SECURITY_SETEO>();
}
