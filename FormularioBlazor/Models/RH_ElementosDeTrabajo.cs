using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_ElementosDeTrabajo
{
    public int IdElemento { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool EntregaPeriodica { get; set; }

    public short Meses { get; set; }

    public bool ReqDevolucion { get; set; }

    public bool ReqIdentificacion { get; set; }

    public bool Certificacion { get; set; }

    public int? IdObservaciones { get; set; }

    public byte[]? DocAsociado { get; set; }

    public string? DescDocAsociado { get; set; }

    public int? CodEmp { get; set; }

    public virtual RTF_Textos? IdObservacionesNavigation { get; set; }

    public virtual ICollection<RH_ElementosAtributos> RH_ElementosAtributos { get; set; } = new List<RH_ElementosAtributos>();

    public virtual ICollection<RH_ElementosCapacitaciones> RH_ElementosCapacitaciones { get; set; } = new List<RH_ElementosCapacitaciones>();

    public virtual ICollection<RH_ElementosPuestos> RH_ElementosPuestos { get; set; } = new List<RH_ElementosPuestos>();
}
