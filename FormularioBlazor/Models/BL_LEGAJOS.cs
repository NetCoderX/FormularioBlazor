using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LEGAJOS
{
    public int IdLegajo { get; set; }

    public string Legajo { get; set; } = null!;

    public DateTime? FecBaseAnt { get; set; }

    public DateTime? FecIngreso { get; set; }

    public DateTime? FecEgreso { get; set; }

    public int IdConvenio { get; set; }

    public string? Observaciones { get; set; }

    public string? Cargo { get; set; }

    public decimal? SueldoBasicoRec { get; set; }

    public string? Categoria { get; set; }

    public decimal? RedUltLiq { get; set; }

    public string? TareaDesemp { get; set; }

    public int? IdFormulaBasRec { get; set; }

    public int? IdFormulaBasCal { get; set; }

    public short? Zona { get; set; }

    public int? Actividad { get; set; }

    public decimal? PorApoAdi { get; set; }

    public decimal? ExcedenteASS { get; set; }

    public decimal? ExcedenteAOS { get; set; }

    public decimal? AporteVolunt { get; set; }

    public decimal? AcAnRet { get; set; }

    public byte? DiasVacaciones { get; set; }

    public bool Discapacidad { get; set; }

    public int? IdSituacion { get; set; }

    public int? NroDomExplot { get; set; }

    public string? CodigoBaja { get; set; }

    public string? ObservsLibro { get; set; }

    public string? CentroA { get; set; }

    public string? CentroB { get; set; }

    public short? ModContratacion { get; set; }

    public byte? CondLaboral { get; set; }

    public int? LiqEgreso { get; set; }

    public string? CAT { get; set; }

    public byte? Incapacidad { get; set; }

    public decimal? CapitalRecomp { get; set; }

    public int IdPersona { get; set; }

    public short CodEmp { get; set; }

    public string? Regimen { get; set; }

    public string? Oficina { get; set; }

    public string? email { get; set; }

    public string? TelDirecto { get; set; }

    public string? TelInterno { get; set; }

    public byte? DiasTrabajados { get; set; }

    public DateTime? FecBaseIndem { get; set; }

    public int? IdLugar { get; set; }

    public int? HorasTrabajadas { get; set; }

    public decimal? PorTareaDif { get; set; }

    public int? IdCategoria { get; set; }

    public bool CoberturaSVO { get; set; }

    public DateTime? FecJubilacion { get; set; }

    public bool GrossingUp { get; set; }

    public bool PublicarRecibos { get; set; }

    public bool HabilitadoAutogestion { get; set; }

    public bool PublicarVisor4ta { get; set; }

    public virtual ICollection<BL_EMPLEADOSACARGO> BL_EMPLEADOSACARGOIdLegajoNavigation { get; set; } = new List<BL_EMPLEADOSACARGO>();

    public virtual ICollection<BL_EMPLEADOSACARGO> BL_EMPLEADOSACARGOIdManagerNavigation { get; set; } = new List<BL_EMPLEADOSACARGO>();

    public virtual ICollection<BL_LEGAJOSATRIBUTOS> BL_LEGAJOSATRIBUTOS { get; set; } = new List<BL_LEGAJOSATRIBUTOS>();

    public virtual ICollection<BL_LIQUIDACIONESDET> BL_LIQUIDACIONESDET { get; set; } = new List<BL_LIQUIDACIONESDET>();

    public virtual ICollection<BL_NovedadesPedidos_Detalle> BL_NovedadesPedidos_Detalle { get; set; } = new List<BL_NovedadesPedidos_Detalle>();

    public virtual ICollection<BL_RECIBOS> BL_RECIBOS { get; set; } = new List<BL_RECIBOS>();

    public virtual ICollection<BL_SECURITY_SETEO> BL_SECURITY_SETEO { get; set; } = new List<BL_SECURITY_SETEO>();

    public virtual EMPRESAS CodEmpNavigation { get; set; } = null!;

    public virtual BL_CONVENIOS IdConvenioNavigation { get; set; } = null!;

    public virtual BL_PERSONAS IdPersonaNavigation { get; set; } = null!;

    public virtual BL_SITUACIONESREVISTA? IdSituacionNavigation { get; set; }
}
