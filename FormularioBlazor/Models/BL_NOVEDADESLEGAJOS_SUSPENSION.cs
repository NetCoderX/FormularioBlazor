using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_NOVEDADESLEGAJOS_SUSPENSION
{
    public int IdOcurrencia { get; set; }

    public int? IdLegajo { get; set; }

    public string? codAtr { get; set; }

    public string? codAtrVal { get; set; }

    public decimal? Nota { get; set; }

    public decimal? Valor { get; set; }

    public DateTime? FecNotifJustif { get; set; }

    public byte? Notificado { get; set; }

    public decimal? SancionDias { get; set; }

    public byte[]? TimeStamp { get; set; }

    public DateTime? FecPrevNot { get; set; }

    public decimal? DiasGozados { get; set; }

    public DateTime? FecIngreso { get; set; }

    public DateTime? FecEgreso { get; set; }

    public DateTime? FecBaseAnt { get; set; }

    public string? Comentario { get; set; }

    public DateTime? FecBaseIndem { get; set; }

    public int Orden { get; set; }

    public virtual ATRIBUTOSVAL? ATRIBUTOSVAL { get; set; }

    public virtual BL_LEGAJOS? IdLegajoNavigation { get; set; }

    public virtual BL_NOVEDADES_SUSPENSION IdOcurrenciaNavigation { get; set; } = null!;
}
