using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LIQUIDACIONESTIPOS
{
    public int IdLiqTipo { get; set; }

    public string CodLiq { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool SAC { get; set; }

    public bool Egreso { get; set; }

    public byte ConNovParaLiqTipo { get; set; }

    public byte DepositoCtaBancAlt { get; set; }

    public byte? Complementaria { get; set; }

    public bool Ganancias { get; set; }

    public virtual ICollection<BL_CONCEPTOSTIPOLIQ> BL_CONCEPTOSTIPOLIQ { get; set; } = new List<BL_CONCEPTOSTIPOLIQ>();

    public virtual ICollection<BL_LIQUIDACIONES> BL_LIQUIDACIONES { get; set; } = new List<BL_LIQUIDACIONES>();

    public virtual ICollection<BL_NOVEDADES> BL_NOVEDADES { get; set; } = new List<BL_NOVEDADES>();

    public virtual ICollection<BL_NOVEDADES_SUSPENSION> BL_NOVEDADES_SUSPENSION { get; set; } = new List<BL_NOVEDADES_SUSPENSION>();
}
