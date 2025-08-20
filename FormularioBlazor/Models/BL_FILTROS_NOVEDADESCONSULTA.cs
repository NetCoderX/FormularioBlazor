using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_FILTROS_NOVEDADESCONSULTA
{
    public string CodFiltro { get; set; } = null!;

    public int CodEmp { get; set; }

    public string Usuario { get; set; } = null!;

    public string TipoFiltro { get; set; } = null!;

    public string? Filtro { get; set; }
}
