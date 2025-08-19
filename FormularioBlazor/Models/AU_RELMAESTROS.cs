using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AU_RELMAESTROS
{
    public int IdAud { get; set; }

    public string Maestro { get; set; } = null!;

    public string TablaId { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? JoinParaHistoria { get; set; }

    public string? SelectParaHistoria { get; set; }
}
