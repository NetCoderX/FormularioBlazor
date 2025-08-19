using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAutogestion_Familiares2
{
    public int IdPersona { get; set; }

    public int IdFamiliar { get; set; }

    public int Secuencia { get; set; }

    public string? Nombres { get; set; }

    public string? Apellido { get; set; }

    public string? FecNacimiento { get; set; }

    public string Parentesco { get; set; } = null!;

    public string? FecACargo { get; set; }
}
