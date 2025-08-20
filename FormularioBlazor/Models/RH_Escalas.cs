using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Escalas
{
    public int IdEscala { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? ValorMin { get; set; }

    public int? ValorMax { get; set; }

    public short? CodEmp { get; set; }

    public virtual ICollection<RH_Escalas_Valores> RH_Escalas_Valores { get; set; } = new List<RH_Escalas_Valores>();

    public virtual ICollection<RH_Evaluaciones> RH_Evaluaciones { get; set; } = new List<RH_Evaluaciones>();
}
