using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAutogestion_Recibos
{
    public string? Clave { get; set; }

    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public int IdPersona { get; set; }

    public string LegajoCodigo { get; set; } = null!;

    public string? PDF_Nombre { get; set; }

    public string? PDF_RutaLOC { get; set; }

    public string? PDF_RutaFTP { get; set; }

    public DateTime? FTPUpLoad { get; set; }

    public DateTime? ArchivoGananciasUpload { get; set; }

    public byte Firmado { get; set; }

    public DateTime? Firmado_Fecha { get; set; }

    public string? Observacion { get; set; }

    public DateTime? Visualizado { get; set; }

    public string? Empresa { get; set; }

    public DateTime Liquidacion_Mes { get; set; }

    public string Liquidacion_Codigo { get; set; } = null!;

    public string? Liquidacion_Nombre { get; set; }

    public string? LugarDeTrabajo { get; set; }
}
