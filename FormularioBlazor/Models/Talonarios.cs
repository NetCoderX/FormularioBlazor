using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class Talonarios
{
    public short nroTalonario { get; set; }

    public string Descripcion { get; set; } = null!;

    public short CodEmp { get; set; }
}
