using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_NovedadesPedidos_Detalle
{
    public int IdOcurrenciaPedido { get; set; }

    public DateTime FecOcurrencia { get; set; }

    public short EstadoAnterior { get; set; }

    public short EstadoNuevo { get; set; }

    public string? Observaciones { get; set; }

    public string? UsuarioCambioDeEstado { get; set; }

    public int? IdLegajoCambioDeEstado { get; set; }

    public virtual BL_LEGAJOS? IdLegajoCambioDeEstadoNavigation { get; set; }

    public virtual BL_NovedadesPedidos IdOcurrenciaPedidoNavigation { get; set; } = null!;
}
