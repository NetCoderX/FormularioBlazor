using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_VARIABLESPREDEFINIDAS
{
    public int IDVARIABLE { get; set; }

    public string CODIGO { get; set; } = null!;

    public string DESCRIPCION { get; set; } = null!;

    public string COMMANDTEXT { get; set; } = null!;

    public byte COMMANDTYPE { get; set; }
}
