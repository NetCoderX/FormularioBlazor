using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LIQUIDACIONES
{
    public int IdLiquidacion { get; set; }

    public string? Descripcion { get; set; }

    public int IdLiqTipo { get; set; }

    public DateTime MesLiq { get; set; }

    public DateTime? MesPago { get; set; }

    public byte? SAC { get; set; }

    public byte? Egreso { get; set; }

    public DateTime FechaDesde { get; set; }

    public DateTime FechaHasta { get; set; }

    public short CodEmp { get; set; }

    public byte ResumenContableEmitido { get; set; }

    public byte LibroSueldosEmitido { get; set; }

    public byte Cerrada { get; set; }

    public DateTime? FechaCierre { get; set; }

    public int? nroTransacAsientos { get; set; }

    public bool? Simulacion { get; set; }

    public virtual ICollection<BL_LIQUIDACIONESDET> BL_LIQUIDACIONESDET { get; set; } = new List<BL_LIQUIDACIONESDET>();

    public virtual ICollection<BL_RECIBOS> BL_RECIBOS { get; set; } = new List<BL_RECIBOS>();

    public virtual BL_LIQUIDACIONESTIPOS IdLiqTipoNavigation { get; set; } = null!;
}
