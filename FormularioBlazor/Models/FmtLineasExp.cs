using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class FmtLineasExp
{
    public string codFmt { get; set; } = null!;

    public string Origen { get; set; } = null!;

    public string? Id { get; set; }

    public string? Texto { get; set; }

    public short? colInicio { get; set; }

    public short? Longitud { get; set; }

    public int Secuencia { get; set; }

    public string? FmtNroFecha { get; set; }

    public string Zona { get; set; } = null!;

    public short? Linea { get; set; }

    public short? Totalizador { get; set; }

    public string? Operacion { get; set; }

    public virtual FormatosExp codFmtNavigation { get; set; } = null!;
}
