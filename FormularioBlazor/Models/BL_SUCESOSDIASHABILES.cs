using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_SUCESOSDIASHABILES
{
    public int IdSuceso { get; set; }

    public string? CodAtrVal { get; set; }

    public int? IdConvenio { get; set; }

    public int UsaDiasHabiles { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual BL_SUCESOS IdSucesoNavigation { get; set; } = null!;
}
