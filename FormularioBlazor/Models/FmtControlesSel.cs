using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class FmtControlesSel
{
    public int Id { get; set; }

    public string TipoFmt { get; set; } = null!;

    public string Columna { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string txtJoin { get; set; } = null!;

    public string txtGroupBy { get; set; } = null!;

    public string txtWhere { get; set; } = null!;
}
