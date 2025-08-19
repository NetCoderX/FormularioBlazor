using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_PuestosHistorico
{
    public int IdPuesto { get; set; }

    public string? Nombre { get; set; }

    public bool Vigente { get; set; }

    public DateTime FechaReg { get; set; }

    public virtual ICollection<RH_NovedadesPuestos> RH_NovedadesPuestos { get; set; } = new List<RH_NovedadesPuestos>();
}
