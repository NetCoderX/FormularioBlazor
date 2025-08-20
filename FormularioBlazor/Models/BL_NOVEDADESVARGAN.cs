using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_NOVEDADESVARGAN
{
    public int IdNovedadGan { get; set; }

    public int IdVariable { get; set; }

    public string? Descripcion { get; set; }

    public string? CUIT { get; set; }

    public string? DescripcionA { get; set; }

    public string? DescripcionB { get; set; }

    public DateTime VtoMesAnioDesde { get; set; }

    public DateTime? VtoMesAnioHasta { get; set; }

    public decimal? Importe { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public string? Planilla { get; set; }

    public virtual BL_NOVEDADESGAN IdNovedadGanNavigation { get; set; } = null!;

    public virtual BL_VARIABLESGANANCIAS IdVariableNavigation { get; set; } = null!;
}
