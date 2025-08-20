using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class TipoDocSync
{
    public string CODDOC { get; set; } = null!;

    public string DESCRIPCION { get; set; } = null!;

    public byte? VALIDACION { get; set; }
}
