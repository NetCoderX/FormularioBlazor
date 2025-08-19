using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ProvinciasSync
{
    public short CODEMP { get; set; }

    public string NROPROVINCIA { get; set; } = null!;

    public string NOMBRE { get; set; } = null!;
}
