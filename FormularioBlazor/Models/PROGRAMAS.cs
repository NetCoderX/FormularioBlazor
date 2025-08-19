using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class PROGRAMAS
{
    public short CODPROG { get; set; }

    public string DESCRIPCION { get; set; } = null!;

    public string PROGRAMA { get; set; } = null!;

    public string? PROGRAMAWEB { get; set; }

    public string? HTMLHELP { get; set; }

    public virtual ICollection<BRCONFIG> BRCONFIG { get; set; } = new List<BRCONFIG>();
}
