using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAUDI_ACUMULADORES
{
    public int IdAcumulador { get; set; }

    public string? Acumulador { get; set; }

    public string? Mayor_Valor { get; set; }

    public string? Incluir_Liq__Actual { get; set; }

    public string? Ultima_Liq__Mes_Actual { get; set; }

    public string? Liquidaciones_anteriores_del_mes_actual { get; set; }

    public string? Meses_a_considerar { get; set; }

    public string? Años_a_considerar { get; set; }

    public string? Sólo_última_liquidación { get; set; }

    public string? Permite_carga_inicial { get; set; }

    public string? Considerar_Imp__Prorrateados { get; set; }

    public string? Incluir_concepto_de_Haberes { get; set; }

    public string? Incluir_concepto_de_Retenciones { get; set; }

    public string? Incluir_concepto_de_Asig__Fam_ { get; set; }

    public string? Incluir_concepto_de_Redondeo { get; set; }

    public string? Incluir_concepto_de_Contribuciones { get; set; }
}
