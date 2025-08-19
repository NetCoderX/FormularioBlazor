using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LEGAJOSATRIBUTOS
{
    public int IdLegajo { get; set; }

    public string CodAtr { get; set; } = null!;

    public string CodAtrVal { get; set; } = null!;

    public byte[]? Timestamp { get; set; }

    public virtual ATRIBUTOSVAL ATRIBUTOSVAL { get; set; } = null!;

    public virtual ATRIBUTOS CodAtrNavigation { get; set; } = null!;

    public virtual BL_LEGAJOS IdLegajoNavigation { get; set; } = null!;
}
