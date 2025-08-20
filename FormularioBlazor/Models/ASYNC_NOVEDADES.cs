using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ASYNC_NOVEDADES
{
    public int Id { get; set; }

    public int IdProceso { get; set; }

    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public int? idocurrencia { get; set; }

    public byte? ClaseConcepto { get; set; }

    public short? NroConcepto { get; set; }

    public string? ConceptoDesc { get; set; }

    public byte? Auxiliar { get; set; }

    public string? ExprFormula { get; set; }

    public int? CodCueDeu { get; set; }

    public int? CodCueAcr { get; set; }

    public int? idConcepto { get; set; }

    public string? CodVariable { get; set; }

    public string? VarEnRec { get; set; }

    public string? Observacion { get; set; }

    public bool? Mes1 { get; set; }

    public bool? Mes2 { get; set; }

    public bool? Mes3 { get; set; }

    public bool? Mes4 { get; set; }

    public bool? Mes5 { get; set; }

    public bool? Mes6 { get; set; }

    public bool? Mes7 { get; set; }

    public bool? Mes8 { get; set; }

    public bool? Mes9 { get; set; }

    public bool? Mes10 { get; set; }

    public bool? Mes11 { get; set; }

    public bool? Mes12 { get; set; }

    public string? TipoProrrateoPeriodos { get; set; }

    public byte? MesesPosteriores { get; set; }

    public byte? MesesAnteriores { get; set; }

    public byte? MesActual { get; set; }

    public byte? ProrrateaGanancias { get; set; }

    public string? CentroA { get; set; }

    public string? CentroB { get; set; }

    public virtual ASYNC_PROCESOS IdProcesoNavigation { get; set; } = null!;
}
