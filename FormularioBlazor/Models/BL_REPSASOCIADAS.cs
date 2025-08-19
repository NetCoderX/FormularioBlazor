using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_REPSASOCIADAS
{
    public int IdLegajo { get; set; }

    public int IdReparticion { get; set; }

    public string? NroInscrLegajo { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public DateTime? FecAlta { get; set; }

    public string? CBU { get; set; }

    public virtual BL_LEGAJOS IdLegajoNavigation { get; set; } = null!;

    public virtual BL_REPARTICIONES IdReparticionNavigation { get; set; } = null!;
}
