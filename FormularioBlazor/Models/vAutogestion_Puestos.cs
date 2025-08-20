using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAutogestion_Puestos
{
    public string? Empresa { get; set; }

    public string? NombrePuesto { get; set; }

    public int IdPersona { get; set; }

    public int? IdLegajo { get; set; }
}
