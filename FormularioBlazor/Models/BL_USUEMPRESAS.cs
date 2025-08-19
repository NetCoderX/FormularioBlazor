using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_USUEMPRESAS
{
    public string USERNAME { get; set; } = null!;

    public short CODEMP { get; set; }

    public byte? COMPROBANTES { get; set; }

    public byte? INFORMES { get; set; }

    public byte? INFDEFAULT { get; set; }

    public virtual EMPRESAS CODEMPNavigation { get; set; } = null!;
}
