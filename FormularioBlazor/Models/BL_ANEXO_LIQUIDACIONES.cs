using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_ANEXO_LIQUIDACIONES
{
    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public string? CentroA { get; set; }

    public string? CentroB { get; set; }

    public DateTime? FecIngreso { get; set; }

    public DateTime? FecEgreso { get; set; }

    public string? PagoLugar { get; set; }

    public int? IdEstadoCivil { get; set; }

    public byte? NroEstadoCivil { get; set; }

    public string? EstadoCivil { get; set; }

    public short? ModContratacion { get; set; }

    public string? ModContratacionDesc { get; set; }

    public int? IdSituacion { get; set; }

    public short? NroSituacion { get; set; }

    public string? DescSituacion { get; set; }

    public short? Zona { get; set; }

    public string? ZonaDescripcion { get; set; }

    public string? LugarTrabajo { get; set; }

    public DateTime? PagoFecha { get; set; }

    public string? LugarTrabajoCodigo { get; set; }

    public int? LugarTrabajoId { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdConvenio { get; set; }

    public string? ObraSocialCod { get; set; }

    public string? ObraSocialDesc { get; set; }

    public string? BancoPagoCod { get; set; }

    public string? BancoPagoDesc { get; set; }

    public string? NroInscrLegajo { get; set; }

    public byte? TipoObraSocial { get; set; }

    public string? CBU { get; set; }

    public short? FormaPago { get; set; }

    public DateTime? FecBaseAnt { get; set; }

    public DateTime? FecBaseIndem { get; set; }
}
