using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BRCONFIGDET
{
    public string USUARIO { get; set; } = null!;

    public short CODPROG { get; set; }

    public short CODBROWSE { get; set; }

    public string COLUMNA { get; set; } = null!;

    public decimal? ANCHO { get; set; }

    public byte VISIBLE { get; set; }

    public string? FILTRO { get; set; }

    public short ORDEN { get; set; }

    public byte BUSQUEDA { get; set; }

    public string? TIPORDEN { get; set; }

    public string? CODATR { get; set; }

    public byte? DATOATR { get; set; }

    public virtual BRCONFIG BRCONFIG { get; set; } = null!;

    public virtual BRTABLASCOLS BRTABLASCOLS { get; set; } = null!;

    public virtual BRTABLAS CODBROWSENavigation { get; set; } = null!;
}
