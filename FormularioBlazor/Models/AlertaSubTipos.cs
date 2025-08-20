using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AlertaSubTipos
{
    public int IdSubTipoAlerta { get; set; }

    public string SubTipoNombre { get; set; } = null!;

    public int IdTipoAlerta { get; set; }

    public int? TiempoProceso { get; set; }

    public virtual ICollection<AlertasAgenda> AlertasAgenda { get; set; } = new List<AlertasAgenda>();
}
