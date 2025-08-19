using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_TIPOSEMPLEADORES
{
    public short Codigo { get; set; }

    public DateTime? VigenciaDesde { get; set; }

    public DateTime? VigenciaHasta { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Codigo2 { get; set; }
}
