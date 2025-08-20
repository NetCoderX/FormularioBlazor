using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vHabilidadesPuestos
{
    public int IdPersona { get; set; }

    public int? IdPuesto { get; set; }

    public int IdHabilidad { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Imprescindible { get; set; } = null!;

    public string Cumple { get; set; } = null!;
}
