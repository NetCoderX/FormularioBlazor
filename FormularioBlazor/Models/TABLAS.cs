using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class TABLAS
{
    public short CODTAB { get; set; }

    public string NOMBRE { get; set; } = null!;

    public string TIPO { get; set; } = null!;

    public string ACTUCOT { get; set; } = null!;

    public string? SIMBOLO { get; set; }

    public byte DECIMALES { get; set; }

    public short FACTOR { get; set; }

    public virtual ICollection<CUENTAS> CUENTAS { get; set; } = new List<CUENTAS>();
}
