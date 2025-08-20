using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BRTABLASCOLS
{
    public short CODBROWSE { get; set; }

    public string COLUMNA { get; set; } = null!;

    public string? DESCRIPCION { get; set; }

    public string? TITULO { get; set; }

    public string? TIPO { get; set; }

    public int? CODJOIN { get; set; }

    public byte COPIA { get; set; }

    public decimal? ANCHO { get; set; }

    public byte INVISIBLE { get; set; }

    public byte CONSOLIDADO { get; set; }

    public byte GRUPO { get; set; }

    public byte GRUPOBLIGATORIO { get; set; }

    public int? CODCASE { get; set; }

    public byte NOELEGIBLE { get; set; }

    public string? VALORNOELEGIBLE { get; set; }

    public byte IGUALVALOR { get; set; }

    public virtual ICollection<BRCONFIGDET> BRCONFIGDET { get; set; } = new List<BRCONFIGDET>();

    public virtual BRTABLAS CODBROWSENavigation { get; set; } = null!;
}
