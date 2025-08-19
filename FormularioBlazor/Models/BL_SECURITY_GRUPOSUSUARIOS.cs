using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_SECURITY_GRUPOSUSUARIOS
{
    public int IdUsuario { get; set; }

    public int IdGrupo { get; set; }

    public string? NOMBREGRUPO { get; set; }
}
