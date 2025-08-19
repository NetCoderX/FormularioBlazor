using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class FX_ScriptExec
{
    public string IdScript { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string IdScripts { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Dependencias { get; set; } = null!;
}
