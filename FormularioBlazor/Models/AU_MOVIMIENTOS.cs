using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AU_MOVIMIENTOS
{
    public int IdMovimiento { get; set; }

    public int? IdAud { get; set; }

    public int IdTablaId { get; set; }

    public string? CodObjeto { get; set; }

    public byte? Operacion { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Fecha { get; set; }

    public string? NombreMaquina { get; set; }
}
