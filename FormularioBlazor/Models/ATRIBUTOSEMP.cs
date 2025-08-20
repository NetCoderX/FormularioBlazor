using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ATRIBUTOSEMP
{
    public string CODATR { get; set; } = null!;

    public short CODEMP { get; set; }

    public byte[] TIMESTAMP { get; set; } = null!;

    public virtual ATRIBUTOS CODATRNavigation { get; set; } = null!;

    public virtual EMPRESAS CODEMPNavigation { get; set; } = null!;
}
