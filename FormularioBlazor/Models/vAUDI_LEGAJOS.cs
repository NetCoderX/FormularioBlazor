using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAUDI_LEGAJOS
{
    public int IdLegajo { get; set; }

    public int IdPersona { get; set; }

    public int? IdCategoria { get; set; }

    public int IdConvenio { get; set; }

    public string Legajo { get; set; } = null!;

    public int? IdSituacion { get; set; }

    public int? IdLugar { get; set; }

    public string? Persona { get; set; }

    public string? Convenio { get; set; }

    public string? Modalidad_de_Contratación { get; set; }

    public string? Condición_Laboral { get; set; }

    public string? Actividad { get; set; }

    public string? Zona { get; set; }

    public string? Incapacidad { get; set; }

    public string? Situación_de_Revista { get; set; }

    public string? Lugar_de_Trabajo { get; set; }

    public string? Categoría { get; set; }

    public string? Centro_A { get; set; }

    public string? Centro_B { get; set; }

    public string? Empresa { get; set; }

    public DateTime? Fecha_Base_de_Antigüedad { get; set; }

    public DateTime? Fecha_Base_de_Indemnización { get; set; }

    public DateTime? Fecha_de_Ingreso { get; set; }

    public DateTime? Fecha_de_Egreso { get; set; }

    public string? Observaciones { get; set; }

    public string? Cargo { get; set; }

    public decimal? SueldoBasicoRec { get; set; }

    public decimal? CapitalRecomp { get; set; }

    public decimal? RedUltLiq { get; set; }

    public decimal? PorApoAdi { get; set; }

    public decimal? ExcedenteASS { get; set; }

    public decimal? ExcedenteAOS { get; set; }

    public decimal? AporteVolunt { get; set; }

    public byte? DiasVacaciones { get; set; }

    public string? Regimen { get; set; }

    public bool Discapacidad { get; set; }

    public int? NroDomExplot { get; set; }

    public string? ObservsLibro { get; set; }

    public string? Oficina { get; set; }

    public string? Email { get; set; }

    public string? TelDirecto { get; set; }

    public string? TelInterno { get; set; }

    public byte? DiasTrabajados { get; set; }

    public int? HorasTrabajadas { get; set; }

    public decimal? PorTareaDif { get; set; }

    public bool CoberturaSVO { get; set; }
}
