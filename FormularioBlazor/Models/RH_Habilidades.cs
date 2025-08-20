using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Habilidades
{
    public int IdHabilidad { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public short? CodEmp { get; set; }

    public virtual ICollection<RH_AlternativasCapacitaciones> RH_AlternativasCapacitaciones { get; set; } = new List<RH_AlternativasCapacitaciones>();

    public virtual ICollection<RH_AlternativasDocumentos> RH_AlternativasDocumentos { get; set; } = new List<RH_AlternativasDocumentos>();

    public virtual ICollection<RH_AlternativasEvaluaciones> RH_AlternativasEvaluaciones { get; set; } = new List<RH_AlternativasEvaluaciones>();

    public virtual ICollection<RH_HabilidadesAdHoc> RH_HabilidadesAdHoc { get; set; } = new List<RH_HabilidadesAdHoc>();

    public virtual ICollection<RH_HabilidadesAlternativas> RH_HabilidadesAlternativas { get; set; } = new List<RH_HabilidadesAlternativas>();

    public virtual ICollection<RH_PuestosHabilidades> RH_PuestosHabilidades { get; set; } = new List<RH_PuestosHabilidades>();
}
