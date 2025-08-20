using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class Bl_AutogestionCambiosPerPendientes
{
    public int IdCambios { get; set; }

    public int IdPersona { get; set; }

    public string Tipo { get; set; } = null!;

    public DateTime FecOcurrencia { get; set; }

    public string? Email { get; set; }

    public bool? HabilitadoAutogestion { get; set; }
}
