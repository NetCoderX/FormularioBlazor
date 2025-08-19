using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Evaluaciones
{
    public int IdEvaluacion { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int IdEscala { get; set; }

    public short? CodEmp { get; set; }

    public bool? TieneVencimiento { get; set; }

    public bool? Adhoc { get; set; }

    public virtual RH_Escalas IdEscalaNavigation { get; set; } = null!;

    public virtual ICollection<RH_AlternativasEvaluaciones> RH_AlternativasEvaluaciones { get; set; } = new List<RH_AlternativasEvaluaciones>();

    public virtual ICollection<RH_CapacitacionesEvaluaciones> RH_CapacitacionesEvaluaciones { get; set; } = new List<RH_CapacitacionesEvaluaciones>();

    public virtual ICollection<RH_EvaluacionesFormularios> RH_EvaluacionesFormularios { get; set; } = new List<RH_EvaluacionesFormularios>();

    public virtual ICollection<RH_PlanesEvaluaciones> RH_PlanesEvaluaciones { get; set; } = new List<RH_PlanesEvaluaciones>();

    public virtual ICollection<RH_PlanesFormularios> RH_PlanesFormularios { get; set; } = new List<RH_PlanesFormularios>();
}
