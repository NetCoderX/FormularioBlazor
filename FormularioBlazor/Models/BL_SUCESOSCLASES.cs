using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_SUCESOSCLASES
{
    public int IdClaseSuceso { get; set; }

    public string CodClaseSuceso { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Tratamiento { get; set; } = null!;

    public string? codAtr { get; set; }

    public bool Tope { get; set; }

    public string? TipoTope { get; set; }

    public byte AfectaSAC { get; set; }

    public string? FechaAfectada { get; set; }

    public bool Fecha_Antiguedad { get; set; }

    public bool Fecha_Indemnizacion { get; set; }

    public bool Fecha_Ingreso { get; set; }

    public bool Fecha_Egreso { get; set; }

    public byte AfectaAntiguedad { get; set; }

    public virtual ICollection<BL_SUCESOS> BL_SUCESOS { get; set; } = new List<BL_SUCESOS>();

    public virtual ATRIBUTOS? codAtrNavigation { get; set; }
}
