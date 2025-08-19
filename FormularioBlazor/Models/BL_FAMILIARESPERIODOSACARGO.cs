using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_FAMILIARESPERIODOSACARGO
{
    public int idFamiliar { get; set; }

    public DateTime FecACargoDesde { get; set; }

    public DateTime? FecACargoHasta { get; set; }

    public string ACargoEn { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;

    public int porcentajeDeduccion { get; set; }

    public DateTime? fechaLimite { get; set; }
}
