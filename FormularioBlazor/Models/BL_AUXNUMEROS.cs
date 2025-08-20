using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_AUXNUMEROS
{
    public string TipoVec { get; set; } = null!;

    public byte Elemento { get; set; }

    public string Numero { get; set; } = null!;
}
