using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AlertasAgenda
{
    public int IdAlertaAgenda { get; set; }

    public int IdSubTipoAlerta { get; set; }

    public int Clave1 { get; set; }

    public int Clave2 { get; set; }

    public int Clave3 { get; set; }

    public DateTime Fecha { get; set; }

    public string? TipoFecha { get; set; }

    public int? CodEmp { get; set; }

    public virtual AlertasAgendaRelacion? AlertasAgendaRelacion { get; set; }

    public virtual AlertaSubTipos IdSubTipoAlertaNavigation { get; set; } = null!;
}
