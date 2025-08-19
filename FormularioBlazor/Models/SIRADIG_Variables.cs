using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class SIRADIG_Variables
{
    public int Id { get; set; }

    public string? CodVariable { get; set; }

    public string? Tabla { get; set; }

    public int Tipo { get; set; }

    public short? Motivo { get; set; }

    public string? Descripcion { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string Planilla { get; set; } = null!;
}
