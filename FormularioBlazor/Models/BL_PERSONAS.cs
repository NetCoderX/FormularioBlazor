using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_PERSONAS
{
    public int IdPersona { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Apellido { get; set; }

    public string? ApellidoCasada { get; set; }

    public string? Nombres { get; set; }

    public string? DomicilioCalle { get; set; }

    public string? DomicilioNro { get; set; }

    public string? DomicilioPiso { get; set; }

    public string? DomicilioDepto { get; set; }

    public string? DomicilioLoc { get; set; }

    public string? DomicilioCodPos { get; set; }

    public string? DocNro { get; set; }

    public int? IdNacionalidad { get; set; }

    public int? IdEstado { get; set; }

    public string? Sexo { get; set; }

    public int? IdProvincia { get; set; }

    public DateTime? FecNacimiento { get; set; }

    public string? Telefono { get; set; }

    public string? CUIL { get; set; }

    public byte[]? Foto { get; set; }

    public string? CodDoc { get; set; }

    public string? EmailPersonal { get; set; }

    public bool AfectaSIRADIG { get; set; }

    public bool? PublicarRecibos { get; set; }

    public bool HabilitadoAutogestion { get; set; }

    public bool RecibosPersonasACargo { get; set; }

    public bool DenegarAccesoAutogestion { get; set; }

    public virtual ICollection<BL_FAMILIARES> BL_FAMILIARES { get; set; } = new List<BL_FAMILIARES>();

    public virtual ICollection<BL_LEGAJOS> BL_LEGAJOS { get; set; } = new List<BL_LEGAJOS>();

    public virtual ICollection<BL_PERSONASATRIBUTOS> BL_PERSONASATRIBUTOS { get; set; } = new List<BL_PERSONASATRIBUTOS>();

    public virtual TIPODOC? CodDocNavigation { get; set; }

    public virtual BL_ESTADOSCIVILES? IdEstadoNavigation { get; set; }

    public virtual BL_NACIONALIDADES? IdNacionalidadNavigation { get; set; }

    public virtual BL_PROVINCIAS? IdProvinciaNavigation { get; set; }

    public virtual ICollection<ORG_CarpetaPersona> ORG_CarpetaPersona { get; set; } = new List<ORG_CarpetaPersona>();

    public virtual ICollection<ORG_PuestoPersona> ORG_PuestoPersona { get; set; } = new List<ORG_PuestoPersona>();

    public virtual ICollection<RH_NovedadesPuestos> RH_NovedadesPuestos { get; set; } = new List<RH_NovedadesPuestos>();
}
