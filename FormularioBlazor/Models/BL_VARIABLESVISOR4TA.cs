using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_VARIABLESVISOR4TA
{
    public int Id4ta { get; set; }

    public string Codigo4ta { get; set; } = null!;

    public string Descripcion4ta { get; set; } = null!;

    public int? Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Tipo { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Grupo { get; set; }

    public int? Orden { get; set; }

    public int? VigenciaAnioDesde { get; set; }

    public int? VigenciaAnioHasta { get; set; }
}
