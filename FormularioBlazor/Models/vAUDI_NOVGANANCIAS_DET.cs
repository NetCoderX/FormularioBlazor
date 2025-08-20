using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAUDI_NOVGANANCIAS_DET
{
    public int IdOcurrencia { get; set; }

    public int IdVariable { get; set; }

    public string? Descripcion { get; set; }

    public string? CUIT { get; set; }

    public string? DescripcionA { get; set; }

    public string? DescripcionB { get; set; }

    public DateTime VtoMesAnioDesde { get; set; }

    public DateTime? VtoMesAnioHasta { get; set; }

    public decimal? Valor { get; set; }

    public string? Planilla { get; set; }
}
