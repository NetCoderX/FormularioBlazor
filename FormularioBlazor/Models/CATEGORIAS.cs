using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class CATEGORIAS
{
    public int IdConvenio { get; set; }

    public string CodCat { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public byte[]? TimeStamp { get; set; }

    public int IdCategoria { get; set; }
}
