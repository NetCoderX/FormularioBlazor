using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class NovedadesLegajos
{
    public int Ocurrencia { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Suceso { get; set; }

    public string? Concepto { get; set; }

    public string? Variable { get; set; }

    public string? Cod_Suceso { get; set; }

    public string? Cod_Variable { get; set; }

    public short? Nro_Concepto { get; set; }

    public byte? ClaseConcepto { get; set; }

    public int? IdConcepto { get; set; }

    public int? IdSuceso { get; set; }

    public short CodEmp { get; set; }

    public string? legajo { get; set; }

    public int? idVincSimulacion { get; set; }

    public bool VinculadoLiquidacion { get; set; }

    public string Tratamiento { get; set; } = null!;

    public int? IdLegajo { get; set; }

    public DateTime? VtoMesAnioDesde { get; set; }

    public DateTime? FechaReg { get; set; }

    public string? codliq { get; set; }

    public string? codatr { get; set; }

    public string? codatrVal { get; set; }

    public string? centroA { get; set; }

    public string? centroB { get; set; }
}
