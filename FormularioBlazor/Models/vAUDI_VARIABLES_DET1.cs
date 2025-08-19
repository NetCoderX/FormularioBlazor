using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAUDI_VARIABLES_DET1
{
    public int IdVariable { get; set; }

    public string? Atributo_Valor { get; set; }

    public decimal? Tope_Novedad { get; set; }

    public decimal? Tope_Mensual { get; set; }

    public decimal? Tope_Anual { get; set; }
}
