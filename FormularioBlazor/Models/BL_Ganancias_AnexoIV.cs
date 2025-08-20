using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_Ganancias_AnexoIV
{
    public double SueldoBruto { get; set; }

    public double IncisoC { get; set; }

    public DateTime? VigenciaDesde { get; set; }

    public DateTime? VigenciaHasta { get; set; }
}
