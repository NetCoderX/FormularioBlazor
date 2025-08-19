using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_CONVENIOS
{
    public int IdConvenio { get; set; }

    public string CodConvenio { get; set; } = null!;

    public string Denominacion { get; set; } = null!;

    public int DiasLabsMes { get; set; }

    public int DivisorDiaVacs { get; set; }

    public decimal HorasLabsDia { get; set; }

    public decimal HorasLabsMes { get; set; }

    public byte ConvencionadoSIJP { get; set; }

    public decimal? TopeIndem { get; set; }

    public byte ConsiderarEgresos { get; set; }

    public string? CodAtrAdicional { get; set; }

    public int DiasVacsMenorA6Meses { get; set; }

    public virtual ICollection<BL_LEGAJOS> BL_LEGAJOS { get; set; } = new List<BL_LEGAJOS>();
}
