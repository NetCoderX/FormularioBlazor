using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vPBI_Categorias
{
    public int IdConvenio { get; set; }

    public int Categoria { get; set; }

    public string CodCat { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? DescCombinada { get; set; }
}
