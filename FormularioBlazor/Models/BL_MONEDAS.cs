using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_MONEDAS
{
    public decimal Valor { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
