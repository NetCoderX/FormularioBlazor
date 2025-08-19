using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ORG_Principal
{
    public int IdOrganigrama { get; set; }

    public string CodEmp { get; set; } = null!;

    public virtual ICollection<ORG_Estructuras> ORG_Estructuras { get; set; } = new List<ORG_Estructuras>();
}
