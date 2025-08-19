using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAUDI_FAMILIARES_DET1
{
    public int IdFamiliar { get; set; }

    public int? Clave { get; set; }

    public DateTime FecACargoDesde { get; set; }

    public DateTime? FecACargoHasta { get; set; }
}
