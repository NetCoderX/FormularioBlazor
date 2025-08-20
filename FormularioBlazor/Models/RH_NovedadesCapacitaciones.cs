using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_NovedadesCapacitaciones
{
    public int? IdOcurrencia { get; set; }

    public int? IdCapacitacion { get; set; }

    public int? IdPlanCap { get; set; }

    public short? Etapa { get; set; }

    public int? IdProveedor { get; set; }

    public int? Horas { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public int? IdPersona { get; set; }

    public DateTime? FecDesde { get; set; }

    public DateTime? FecHasta { get; set; }

    public int? IdNovedadEtapaAnterior { get; set; }

    public int? IdOcurrenciaCapGral { get; set; }

    public virtual RH_Capacitaciones? IdCapacitacionNavigation { get; set; }

    public virtual BL_PERSONAS? IdPersonaNavigation { get; set; }

    public virtual RH_PlanesDeCapacitacion? IdPlanCapNavigation { get; set; }

    public virtual RH_Proveedores? IdProveedorNavigation { get; set; }
}
