using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class PERMISOSCAMPOS
{
    public string USUARIO { get; set; } = null!;

    public short CODPROG { get; set; }

    public string CAMPO { get; set; } = null!;

    public short SECUENCIA { get; set; }

    public byte ALTA { get; set; }

    public byte MODIFICACION { get; set; }

    public string? CONTENIDO { get; set; }

    public byte? CONSULTA { get; set; }
}
