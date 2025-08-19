using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAUDI_LEGAJOS_DET2
{
    public int IdLegajo { get; set; }

    public int IdReparticion { get; set; }

    public string? Repartición { get; set; }

    public string? NroInscrLegajo { get; set; }

    public DateTime? FecAlta { get; set; }
}
