using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class MODELIN
{
    public short CODMOD { get; set; }

    public short SECUENCIA { get; set; }

    public string CAMPO { get; set; } = null!;

    public short? FILA { get; set; }

    public string CONTENIDO { get; set; } = null!;

    public string? CONTENIDO2 { get; set; }

    public virtual MODELOS CODMODNavigation { get; set; } = null!;
}
