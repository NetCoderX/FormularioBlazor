using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Puestos
{
    public int IdPuesto { get; set; }

    public string? Nombre { get; set; }

    public int? IdPuestoSup { get; set; }

    public int? IdDocAsociado { get; set; }

    public int? IdVista { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<RH_ElementosPuestos> RH_ElementosPuestos { get; set; } = new List<RH_ElementosPuestos>();

    public virtual ICollection<RH_PuestosHabilidades> RH_PuestosHabilidades { get; set; } = new List<RH_PuestosHabilidades>();
}
