using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class FX_SysVersion
{
    public string IdSistema { get; set; } = null!;

    public string ProyectoVersion { get; set; } = null!;

    public short ProyectoSP { get; set; }
}
