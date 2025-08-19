using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_NovedadesDocumentos
{
    public int? IdOcurrencia { get; set; }

    public int? IdCapacitacion { get; set; }

    public short? Etapa { get; set; }

    public int? IdDocumento { get; set; }

    public DateTime? Vencimiento { get; set; }

    public byte[]? DocAsociado { get; set; }

    public string? DescDocAsociado { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public int? IdPlanCap { get; set; }

    public int? IdPersona { get; set; }

    public int? IdOcurrenciaCapacitacion { get; set; }

    public int? IdObservaciones { get; set; }

    public virtual RH_Capacitaciones? IdCapacitacionNavigation { get; set; }

    public virtual RH_Documentos? IdDocumentoNavigation { get; set; }

    public virtual RTF_Textos? IdObservacionesNavigation { get; set; }

    public virtual BL_PERSONAS? IdPersonaNavigation { get; set; }
}
