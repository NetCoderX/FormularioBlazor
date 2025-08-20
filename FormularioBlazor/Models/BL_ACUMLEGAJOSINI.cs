using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_ACUMLEGAJOSINI
{
    public int idLegajo { get; set; }

    public int idAcumulador { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Valor { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual BL_ACUMULADORES idAcumuladorNavigation { get; set; } = null!;

    public virtual BL_LEGAJOS idLegajoNavigation { get; set; } = null!;
}
