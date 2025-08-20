using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vPBI_ModContrataciones
{
    public short Modalidad_Contratacion { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? DescCombinada { get; set; }
}
