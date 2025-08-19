using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_SECURITY_USUARIOS
{
    public int IdUsuario { get; set; }

    public string Username { get; set; } = null!;

    public virtual ICollection<BL_SECURITY_SETEO> BL_SECURITY_SETEO { get; set; } = new List<BL_SECURITY_SETEO>();
}
