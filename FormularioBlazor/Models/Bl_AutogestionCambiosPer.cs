using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class Bl_AutogestionCambiosPer
{
    public int IdPersona { get; set; }

    public DateTime FecOcurrencia { get; set; }

    public string? Email { get; set; }

    public bool? HabilitadoAutogestion { get; set; }
}
