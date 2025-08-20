using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vLegajosOrganigrama
{
    public int IdLegajo { get; set; }

    public string Legajo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? CAT { get; set; }

    public string? CUIL { get; set; }

    public decimal? CapitalRecomp { get; set; }

    public string? CodCat { get; set; }

    public string? NomCat { get; set; }

    public string? CentroA { get; set; }

    public string? CentroB { get; set; }

    public string? NombreCentroA { get; set; }

    public string? NombreCentroB { get; set; }

    public DateTime? FecJubilacion { get; set; }

    public string Cobertura_SVO { get; set; } = null!;

    public string? CodConvenio { get; set; }

    public string? Denominacion { get; set; }

    public byte? DiasTrabajados { get; set; }

    public byte? DiasVacaciones { get; set; }

    public bool Discapacidad { get; set; }

    public string? DocNro { get; set; }

    public string? eMail { get; set; }

    public short CodEmp { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime? FecBaseAnt { get; set; }

    public DateTime? FecEgreso { get; set; }

    public DateTime? FecBaseIndem { get; set; }

    public DateTime? FecIngreso { get; set; }

    public int? HorasTrabajadas { get; set; }

    public int? LiqEgreso { get; set; }

    public string? PagoLugar { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Observslibro { get; set; }

    public string? Oficina { get; set; }

    public string CodPersona { get; set; } = null!;

    public decimal? PorApoAdi { get; set; }

    public int? Actividad { get; set; }

    public byte? Incapacidad { get; set; }

    public byte? CondLaboral { get; set; }

    public short? modContratacion { get; set; }

    public decimal? PorTareaDif { get; set; }

    public string? Regimen { get; set; }

    public string? TelDirecto { get; set; }

    public string? TelInterno { get; set; }

    public short? zona { get; set; }

    public string Incorporado { get; set; } = null!;
}
