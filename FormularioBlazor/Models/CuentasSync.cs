using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class CuentasSync
{
    public int CODCUE { get; set; }

    public string NOMBRE { get; set; } = null!;

    public string SUBCUENTAS { get; set; } = null!;

    public string CODIGO { get; set; } = null!;

    public string? CODAGR { get; set; }

    public string SDOHAB { get; set; } = null!;

    public short? CODTAB { get; set; }

    public int? CODCUEDEU { get; set; }

    public int? CODCUEACR { get; set; }

    public DateTime? DESDE { get; set; }

    public DateTime? HASTA { get; set; }

    public string? TIPOCUENTA { get; set; }

    public int? CODCUEPRESU { get; set; }

    public short? codempalta { get; set; }
}
