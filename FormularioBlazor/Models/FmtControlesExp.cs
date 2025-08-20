using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class FmtControlesExp
{
    public string TipoFmt { get; set; } = null!;

    public string Columna { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Titulo { get; set; }

    public string? TIPO { get; set; }

    public int? CodJoin { get; set; }

    public short? Ancho { get; set; }

    public byte Obligatoria { get; set; }

    public byte copia { get; set; }

    public byte Invisible { get; set; }

    public byte Grupo { get; set; }

    public byte GrupoObligatorio { get; set; }

    public string? ColumnaXFecPago { get; set; }

    public virtual FmtTiposExp TipoFmtNavigation { get; set; } = null!;
}
