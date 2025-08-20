using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Personas2
{
    public int IdPersona { get; set; }

    public string Codigo { get; set; } = null!;

    public string NombreCompleto { get; set; } = null!;

    public DateTime? FecNacimiento { get; set; }

    public string Puesto { get; set; } = null!;
}
