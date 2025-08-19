using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class SIRADIG_Secuencia
{
    public string CUIL { get; set; } = null!;

    public int Periodo { get; set; }

    public int Secuencia { get; set; }
}
