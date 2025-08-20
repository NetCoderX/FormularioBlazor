using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_FERIADOS
{
    public short ANIO { get; set; }

    public virtual ICollection<BL_FERIADOS_DETALLE> BL_FERIADOS_DETALLE { get; set; } = new List<BL_FERIADOS_DETALLE>();
}
