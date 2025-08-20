using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_SUCESOS
{
    public int IdSuceso { get; set; }

    public string CodSuceso { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool RequiereNotificacion { get; set; }

    public int? IdDocTexto { get; set; }

    public bool VinculadoLiquidacion { get; set; }

    public int IDClaseSuceso { get; set; }

    public int? diasPrevistos { get; set; }

    public string? codAtr { get; set; }

    public bool Tope { get; set; }

    public string? TipoTope { get; set; }

    public int? IdSituacion { get; set; }

    public int? IdConcepto { get; set; }

    public int? IdVariable { get; set; }

    public int? IdVariable2 { get; set; }

    public int? IdVariable3 { get; set; }

    public byte EsVacacion { get; set; }

    public byte AfectaLiquidadas { get; set; }

    public byte AfectaGozadas { get; set; }

    public bool? EsEntrada { get; set; }

    public bool? EsSalida { get; set; }

    public bool EsSuspension { get; set; }

    public bool RequiereReintegro { get; set; }

    public bool AlertaVencimiento { get; set; }

    public bool? HabilitadoAutogestion { get; set; }

    public bool? HabilitadoSoloManager { get; set; }

    public string? AliasAutogestion { get; set; }

    public string? CodAtrDH { get; set; }

    public bool? DiasHabiles { get; set; }

    public virtual ICollection<BL_NOVEDADES> BL_NOVEDADES { get; set; } = new List<BL_NOVEDADES>();

    public virtual ICollection<BL_NOVEDADES_SUSPENSION> BL_NOVEDADES_SUSPENSION { get; set; } = new List<BL_NOVEDADES_SUSPENSION>();

    public virtual BL_SUCESOSCLASES IDClaseSucesoNavigation { get; set; } = null!;

    public virtual BL_DOCSTEXTO? IdDocTextoNavigation { get; set; }

    public virtual ICollection<RH_NovedadesPuestos> RH_NovedadesPuestos { get; set; } = new List<RH_NovedadesPuestos>();

    public virtual ATRIBUTOS? codAtrNavigation { get; set; }
}
