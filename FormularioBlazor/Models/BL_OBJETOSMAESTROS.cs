using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_OBJETOSMAESTROS
{
    public int IdObjeto { get; set; }

    public string NombreTabla { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public DateTime FecAlta { get; set; }

    public string Usuario { get; set; } = null!;
}
