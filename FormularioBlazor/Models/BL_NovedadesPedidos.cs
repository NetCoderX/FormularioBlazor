using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_NovedadesPedidos
{
    public int IdOcurrenciaPedido { get; set; }

    public int? IdLegajo { get; set; }

    public int? IdPersona { get; set; }

    public DateTime FecSolicitud { get; set; }

    public int IdSuceso { get; set; }

    public DateTime FecDesde { get; set; }

    public DateTime FecHasta { get; set; }

    public int Cantidad { get; set; }

    public short? Estado { get; set; }

    public string? Observaciones { get; set; }

    public string? ObservacionesManager { get; set; }

    public string? ObservacionesAdmin { get; set; }

    public virtual ICollection<BL_NovedadesPedidos_Detalle> BL_NovedadesPedidos_Detalle { get; set; } = new List<BL_NovedadesPedidos_Detalle>();
}
