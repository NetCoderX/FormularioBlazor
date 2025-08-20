using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class PERMISOS
{
    public string USUARIO { get; set; } = null!;

    public short SECUENCIA { get; set; }

    public short? DEPENDENCIA { get; set; }

    public string DESCRIPCION { get; set; } = null!;

    public short? CODPROG { get; set; }

    public string? PROGRAMAEXT { get; set; }

    public string? Sistema { get; set; }

    public virtual PROGRAMAS? CODPROGNavigation { get; set; }
}
