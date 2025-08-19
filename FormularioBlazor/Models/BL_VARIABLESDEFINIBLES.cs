using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_VARIABLESDEFINIBLES
{
    public int IdVariable { get; set; }

    public string CodVariable { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Acumular { get; set; }

    public string? TipoAcum { get; set; }

    public string? CodAtr { get; set; }

    public string? TipoTope { get; set; }

    public bool Tope { get; set; }

    public virtual ICollection<BL_CONCEPTOS> BL_CONCEPTOS { get; set; } = new List<BL_CONCEPTOS>();

    public virtual ICollection<BL_NOVEDADESVARIABLES> BL_NOVEDADESVARIABLES { get; set; } = new List<BL_NOVEDADESVARIABLES>();
}
