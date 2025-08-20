using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_CONCEPTOS
{
    public int IdConcepto { get; set; }

    public byte ClaseConcepto { get; set; }

    public short NroConcepto { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? CodCueDeu { get; set; }

    public int? CodCueAcr { get; set; }

    public int? IdFormula { get; set; }

    public string? ExprFormula { get; set; }

    public int? IdVariable { get; set; }

    public bool Mes1 { get; set; }

    public bool Mes2 { get; set; }

    public bool Mes3 { get; set; }

    public bool Mes4 { get; set; }

    public bool Mes5 { get; set; }

    public bool Mes6 { get; set; }

    public bool Mes7 { get; set; }

    public bool Mes8 { get; set; }

    public bool Mes9 { get; set; }

    public bool Mes10 { get; set; }

    public bool Mes11 { get; set; }

    public bool Mes12 { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public bool varReqEnRec { get; set; }

    public byte SinRetenciones { get; set; }

    public byte? Auxiliar { get; set; }

    public string? unEnRecibo { get; set; }

    public byte Ganancias { get; set; }

    public string? CodVarEnRec { get; set; }

    public string TipoProrrateo { get; set; } = null!;

    public string? PeriodoAnt { get; set; }

    public string TipoProrrateoPeriodos { get; set; } = null!;

    public byte MesesAnteriores { get; set; }

    public byte MesesPosteriores { get; set; }

    public byte MesActual { get; set; }

    public byte ProrrateaGanancias { get; set; }

    public string? ObsEnRecibo { get; set; }

    public byte AuxiliarProrratear { get; set; }

    public virtual ICollection<BL_CONCEPTOSTIPOLIQ> BL_CONCEPTOSTIPOLIQ { get; set; } = new List<BL_CONCEPTOSTIPOLIQ>();

    public virtual ICollection<BL_LIQUIDACIONESDET> BL_LIQUIDACIONESDET { get; set; } = new List<BL_LIQUIDACIONESDET>();

    public virtual BL_VARIABLESDEFINIBLES? IdVariableNavigation { get; set; }
}
