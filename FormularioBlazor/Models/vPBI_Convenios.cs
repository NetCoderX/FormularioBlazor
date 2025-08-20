using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vPBI_Convenios
{
    public string Convenio { get; set; } = null!;

    public string Denominacion { get; set; } = null!;

    public string? DescCombinada { get; set; }
}
