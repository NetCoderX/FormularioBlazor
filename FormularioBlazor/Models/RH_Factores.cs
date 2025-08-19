using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Factores
{
    public int IdFactor { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public short? CodEmp { get; set; }

    public virtual ICollection<RH_FormulariosFactores> RH_FormulariosFactores { get; set; } = new List<RH_FormulariosFactores>();
}
