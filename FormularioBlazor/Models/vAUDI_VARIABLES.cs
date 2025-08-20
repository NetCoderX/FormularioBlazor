using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAUDI_VARIABLES
{
    public int IdVariable { get; set; }

    public string? Variable { get; set; }

    public string Acumular_Valores { get; set; } = null!;

    public string Establecer_Topes { get; set; } = null!;

    public string? AcumulaPor { get; set; }

    public string? Tope_Atributo { get; set; }

    public string? Tope_Tipo { get; set; }
}
