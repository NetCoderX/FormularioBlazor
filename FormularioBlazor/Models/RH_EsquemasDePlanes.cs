using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_EsquemasDePlanes
{
    public int IdEsquema { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Frecuencia { get; set; }

    public string? MesInicial { get; set; }

    public bool? AvisoMail { get; set; }

    public bool? AvisoAgenda { get; set; }

    public short? DiasAnticipacion { get; set; }

    public short? CodEmp { get; set; }

    public virtual ICollection<RH_PlanesDeEvaluacion> RH_PlanesDeEvaluacion { get; set; } = new List<RH_PlanesDeEvaluacion>();
}
