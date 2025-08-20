using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RHV_EvidenciasHabilidades
{
    public int? IdOcurrencia { get; set; }

    public int? IdEvidencia { get; set; }

    public int? IdPersona { get; set; }

    public DateTime? FecOcurrencia { get; set; }

    public DateTime? FecVencimiento { get; set; }

    public short? CodEmp { get; set; }
}
