using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_NOVEDADES
{
    public int IdOcurrencia { get; set; }

    public int? IdSuceso { get; set; }

    public DateTime? VtoMesAnioDesde { get; set; }

    public DateTime? VtoMesAnioHasta { get; set; }

    public int? IdLiqTipo { get; set; }

    public string? Observaciones { get; set; }

    public byte[]? Documento { get; set; }

    public DateTime? FecOcurrencia { get; set; }

    public byte[]? Timestamp { get; set; }

    public DateTime? FecVtoContrato { get; set; }

    public string? CentroA { get; set; }

    public string? CentroB { get; set; }

    public int? IdConcepto { get; set; }

    public int? IdVariable { get; set; }

    public int? IdLegajo { get; set; }

    public string? codatr { get; set; }

    public string? codatrval { get; set; }

    public DateTime? FechaReg { get; set; }

    public int? idObjetoElim { get; set; }

    public short CodEmp { get; set; }

    public byte NovedadTipoVacs { get; set; }

    public DateTime? LicFecDesde { get; set; }

    public DateTime? LicFecHasta { get; set; }

    public int? IdVincSimulacion { get; set; }

    public int? IdConvenio { get; set; }

    public DateTime? LicFecReintegro { get; set; }

    public int? IdOcurrenciaPedido { get; set; }

    public virtual ICollection<BL_NOVEDADESVARIABLES> BL_NOVEDADESVARIABLES { get; set; } = new List<BL_NOVEDADESVARIABLES>();

    public virtual EMPRESAS CodEmpNavigation { get; set; } = null!;

    public virtual BL_LIQUIDACIONESTIPOS? IdLiqTipoNavigation { get; set; }

    public virtual BL_SUCESOS? IdSucesoNavigation { get; set; }
}
