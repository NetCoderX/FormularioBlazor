using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_PlanesDeCapacitacion
{
    public int IdPlanCap { get; set; }

    public int? IdEsquema { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FecInicioPlanif { get; set; }

    public DateTime? FecInicioEjec { get; set; }

    public DateTime? FecCierre { get; set; }

    public short? Estado { get; set; }

    public string? Responsables { get; set; }

    public string? ResponsablesPersonas { get; set; }

    public short? CodEmp { get; set; }

    public virtual ICollection<RH_PlanesResponsables> RH_PlanesResponsables { get; set; } = new List<RH_PlanesResponsables>();
}
