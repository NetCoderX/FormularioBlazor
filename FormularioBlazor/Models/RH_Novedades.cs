using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Novedades
{
    public int IdOcurrencia { get; set; }

    public DateTime? FecOcurrencia { get; set; }

    public DateTime? FechaReg { get; set; }

    public short TipoNovedad { get; set; }

    public short? CodEmp { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public int? IdObservaciones { get; set; }

    public byte[]? Documento { get; set; }

    public string? DescDocAsociado { get; set; }

    public virtual ICollection<RH_NovedadesPuestos> RH_NovedadesPuestos { get; set; } = new List<RH_NovedadesPuestos>();
}
