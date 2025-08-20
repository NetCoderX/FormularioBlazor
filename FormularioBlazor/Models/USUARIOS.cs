using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class USUARIOS
{
    public string USERNAME { get; set; } = null!;

    public short CODEMP { get; set; }

    public short? CODSUC { get; set; }

    public short CODEMPBASLB { get; set; }

    public string? NOMBRE { get; set; }

    public string? EMAIL { get; set; }

    public string? TITULOINF { get; set; }

    public string? TITULOINFBASLB { get; set; }

    public byte AXFEC { get; set; }

    public virtual EMPRESAS CODEMPNavigation { get; set; } = null!;
}
