using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LSD_CAB
{
    public int NroLiqAFIP { get; set; }

    public int IdLiquidacion { get; set; }

    public DateOnly? MesLiq { get; set; }

    public int? IdLiqtipo { get; set; }

    public string? TipoCodigo { get; set; }

    public DateTime? FechaDesde { get; set; }

    public DateTime? FechaHasta { get; set; }

    public DateTime? MesPago { get; set; }

    public string? Cuit { get; set; }

    public int? CodEmp { get; set; }

    public string? IdEnvio { get; set; }

    public string? TipoLiq { get; set; }

    public bool? EsRectificativa { get; set; }

    public int? CantLegajos { get; set; }

    public string? IdLegajos { get; set; }

    public bool Presentada { get; set; }

    public DateTime? FechaPresentacion { get; set; }

    public int NroPresentacion { get; set; }

    public int? IdProvincia { get; set; }

    public virtual ICollection<BL_LSD_DET> BL_LSD_DET { get; set; } = new List<BL_LSD_DET>();
}
