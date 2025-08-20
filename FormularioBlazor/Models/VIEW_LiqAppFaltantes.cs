using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class VIEW_LiqAppFaltantes
{
    public int Idliquidacion { get; set; }

    public int? LiqDet { get; set; }

    public int? LiqApp { get; set; }

    public byte ResumenContableEmitido { get; set; }
}
