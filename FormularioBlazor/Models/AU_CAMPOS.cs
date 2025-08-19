using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AU_CAMPOS
{
    public int IdAud { get; set; }

    public int IdCampo { get; set; }

    public string Campo { get; set; } = null!;

    public string CodObjeto { get; set; } = null!;

    public int IdTipo { get; set; }

    public bool EsCampoLogico { get; set; }

    public string? Descripcion { get; set; }

    public string? ObjetoBase { get; set; }

    public string? CampoCod { get; set; }
}
