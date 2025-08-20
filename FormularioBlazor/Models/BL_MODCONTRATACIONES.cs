using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_MODCONTRATACIONES
{
    public short ModContratacion { get; set; }

    public string Descripcion { get; set; } = null!;

    public int DiasAlerta { get; set; }
}
