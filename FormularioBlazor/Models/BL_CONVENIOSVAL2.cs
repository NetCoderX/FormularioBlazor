using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_CONVENIOSVAL2
{
    public int IdConvenio { get; set; }

    public int Anios { get; set; }

    public decimal Valor { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual BL_CONVENIOS IdConvenioNavigation { get; set; } = null!;
}
