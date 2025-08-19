using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_PERSONASATRIBUTOS
{
    public int IdPersona { get; set; }

    public string CodAtr { get; set; } = null!;

    public string CodAtrVal { get; set; } = null!;

    public byte[]? Timestamp { get; set; }

    public virtual ATRIBUTOSVAL ATRIBUTOSVAL { get; set; } = null!;

    public virtual ATRIBUTOS CodAtrNavigation { get; set; } = null!;

    public virtual BL_PERSONAS IdPersonaNavigation { get; set; } = null!;
}
