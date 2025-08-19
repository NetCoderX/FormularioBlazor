using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_NOVEDADESVARIABLES
{
    public int IdOcurrencia { get; set; }

    public int Id { get; set; }

    public int IdVariable { get; set; }

    public decimal? Valor { get; set; }

    public int? IdLegajo { get; set; }

    public string? codAtr { get; set; }

    public string? codAtrVal { get; set; }

    public DateTime? Mes { get; set; }

    public string? CodCat { get; set; }

    public int? IdConvenio { get; set; }

    public virtual BL_NOVEDADES IdOcurrenciaNavigation { get; set; } = null!;

    public virtual BL_VARIABLESDEFINIBLES IdVariableNavigation { get; set; } = null!;
}
