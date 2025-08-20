using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_OBJETOSTRANSACCION
{
    public int IdTransaccion { get; set; }

    public string NombreTabla { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public DateTime FecAlta { get; set; }

    public string Usuario { get; set; } = null!;

    public int? idObjetoModificado { get; set; }
}
