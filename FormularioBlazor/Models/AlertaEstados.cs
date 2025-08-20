using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AlertaEstados
{
    public string MaquinaServicio { get; set; } = null!;

    public int Estado { get; set; }

    public string? MaquinaPedido { get; set; }

    public string? DescError { get; set; }

    public DateTime? UltimaFecha { get; set; }

    public string? TipoAlerta { get; set; }

    public int? IdAlerta { get; set; }
}
