using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAUDI_CONCEPTOS
{
    public int IdConcepto { get; set; }

    public string? Concepto { get; set; }

    public string? Cuenta_Deudor_x_Defecto { get; set; }

    public string? Cuenta_Acreedor_x_Defecto { get; set; }

    public string? Sin_Retenciones { get; set; }

    public string? Es_Auxiliar { get; set; }

    public string? Es_Ganancias { get; set; }

    public string? Formula { get; set; }

    public string? Variable_Requerida { get; set; }

    public string? Recibo_Variable { get; set; }

    public string? Recibo_Unidad { get; set; }

    public string? Recibo_Observación { get; set; }

    public string? Tipo_prorrateo_períodos { get; set; }

    public byte Meses_Anteriores { get; set; }

    public byte Meses_Posteriores { get; set; }

    public string? Dependencia_Centro_de_Costo { get; set; }

    public string? Período_liquidaciones_anteriores { get; set; }

    public string? Enero { get; set; }

    public string? Febrero { get; set; }

    public string? Marzo { get; set; }

    public string? Abril { get; set; }

    public string? Mayo { get; set; }

    public string? Junio { get; set; }

    public string? Julio { get; set; }

    public string? Agosto { get; set; }

    public string? Septiembre { get; set; }

    public string? Octubre { get; set; }

    public string? Noviembre { get; set; }

    public string? Diciembre { get; set; }

    public string? Prorratea_para_ganancias { get; set; }

    public string? Mes_Actual { get; set; }

    public string? Auxiliar_habilitado_para_prorratear { get; set; }
}
