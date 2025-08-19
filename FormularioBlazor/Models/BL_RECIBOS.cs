using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_RECIBOS
{
    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public int? NroRecibo { get; set; }

    public int IdTransaccion { get; set; }

    public string? PagoLugar { get; set; }

    public DateTime? PagoFecha { get; set; }

    public string? ultDepBanco { get; set; }

    public DateTime? UltDepMesCorresp { get; set; }

    public DateTime? UltDepFecha { get; set; }

    public string? ReciboTexto { get; set; }

    public decimal ValorMTS { get; set; }

    public int? IdReparticion { get; set; }

    public string? NroCuenta { get; set; }

    public string? PDF_Nombre { get; set; }

    public string? PDF_RutaLOC { get; set; }

    public string? PDF_RutaFTP { get; set; }

    public string? MD5 { get; set; }

    public DateTime? FTPUpLoad { get; set; }

    public DateTime? Visualizado { get; set; }

    public byte Firmado { get; set; }

    public DateTime? Firmado_Fecha { get; set; }

    public string? Observacion { get; set; }

    public DateTime? ArchivoGananciasUpload { get; set; }

    public virtual BL_LEGAJOS IdLegajoNavigation { get; set; } = null!;

    public virtual BL_LIQUIDACIONES IdLiquidacionNavigation { get; set; } = null!;

    public virtual BL_REPARTICIONES? IdReparticionNavigation { get; set; }
}
