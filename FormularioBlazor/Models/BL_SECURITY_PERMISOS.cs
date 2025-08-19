using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_SECURITY_PERMISOS
{
    public int IdTipo { get; set; }

    public int IdPermiso { get; set; }

    public string Permiso { get; set; } = null!;

    public virtual ICollection<BL_SECURITY_SETEO> BL_SECURITY_SETEO { get; set; } = new List<BL_SECURITY_SETEO>();

    public virtual BL_SECURITY_TIPOS IdTipoNavigation { get; set; } = null!;
}
