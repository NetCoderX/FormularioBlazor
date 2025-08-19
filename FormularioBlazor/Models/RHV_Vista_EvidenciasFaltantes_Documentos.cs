using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RHV_Vista_EvidenciasFaltantes_Documentos
{
    public int? IdOcurrencia { get; set; }

    public int? IdCapacitacion { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? IdPersona { get; set; }

    public int? IdPlanCap { get; set; }

    public short? CodEmp { get; set; }

    public int? IdDocumento { get; set; }

    public int? IdOcurrenciaEvidencia { get; set; }
}
