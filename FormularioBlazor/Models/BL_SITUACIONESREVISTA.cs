using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_SITUACIONESREVISTA
{
    public int IdSituacion { get; set; }

    public short NroSituacion { get; set; }

    public string Descripcion { get; set; } = null!;

    public byte IncluirSIJP { get; set; }

    public virtual ICollection<BL_LEGAJOS> BL_LEGAJOS { get; set; } = new List<BL_LEGAJOS>();
}
