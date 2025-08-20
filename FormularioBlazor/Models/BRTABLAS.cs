using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BRTABLAS
{
    public short CODBROWSE { get; set; }

    public string NOMBRE { get; set; } = null!;

    public string FROMTABLAS { get; set; } = null!;

    public string? TITULOVENTANA { get; set; }

    public string? ALIAS { get; set; }

    public string? FILTRO { get; set; }

    public string? ATRIBUTOS { get; set; }

    public string? FILTROHAVING { get; set; }

    public short tiempoespera { get; set; }

    public virtual ICollection<BRCONFIG> BRCONFIG { get; set; } = new List<BRCONFIG>();

    public virtual ICollection<BRCONFIGDET> BRCONFIGDET { get; set; } = new List<BRCONFIGDET>();

    public virtual ICollection<BRTABLASCOLS> BRTABLASCOLS { get; set; } = new List<BRTABLASCOLS>();
}
