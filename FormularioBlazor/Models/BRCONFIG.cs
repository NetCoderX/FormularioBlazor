using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BRCONFIG
{
    public string USUARIO { get; set; } = null!;

    public short CODPROG { get; set; }

    public short CODBROWSE { get; set; }

    public byte? CODBROWSEDEF { get; set; }

    public bool? PAUTADO { get; set; }

    public bool? RAYADO { get; set; }

    public int? PAUTADOCOLOR { get; set; }

    public short? TOPEFILAS { get; set; }

    public int? NOELEGIBLECOLOR { get; set; }

    public virtual ICollection<BRCONFIGDET> BRCONFIGDET { get; set; } = new List<BRCONFIGDET>();

    public virtual BRTABLAS CODBROWSENavigation { get; set; } = null!;

    public virtual PROGRAMAS CODPROGNavigation { get; set; } = null!;
}
