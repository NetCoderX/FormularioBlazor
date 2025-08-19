using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Formularios
{
    public int IdFormulario { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool? Ponderacion { get; set; }

    public int? IdResultadoAceptable { get; set; }

    public short? CodEmp { get; set; }

    public int? IdEscala { get; set; }

    public virtual ICollection<RH_EvaluacionesFormularios> RH_EvaluacionesFormularios { get; set; } = new List<RH_EvaluacionesFormularios>();

    public virtual ICollection<RH_FormulariosFactores> RH_FormulariosFactores { get; set; } = new List<RH_FormulariosFactores>();

    public virtual ICollection<RH_Formularios_Detalle> RH_Formularios_Detalle { get; set; } = new List<RH_Formularios_Detalle>();

    public virtual ICollection<RH_PlanesFormularios> RH_PlanesFormularios { get; set; } = new List<RH_PlanesFormularios>();
}
