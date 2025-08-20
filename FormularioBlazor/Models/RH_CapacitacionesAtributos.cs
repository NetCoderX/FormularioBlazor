using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_CapacitacionesAtributos
{
    public int IdCapacitacion { get; set; }

    public string CodAtr { get; set; } = null!;

    public string? CodAtrVal { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual ATRIBUTOSVAL? ATRIBUTOSVAL { get; set; }

    public virtual ATRIBUTOS CodAtrNavigation { get; set; } = null!;

    public virtual RH_Capacitaciones IdCapacitacionNavigation { get; set; } = null!;
}
