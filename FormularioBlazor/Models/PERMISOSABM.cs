using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class PERMISOSABM
{
    public string USUARIO { get; set; } = null!;

    public short CODPROG { get; set; }

    public byte ALTA { get; set; }

    public byte BAJA { get; set; }

    public byte MODIFICACION { get; set; }

    public byte? CONSULTA { get; set; }
}
