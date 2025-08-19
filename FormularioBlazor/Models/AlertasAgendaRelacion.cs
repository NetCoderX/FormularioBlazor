using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AlertasAgendaRelacion
{
    public int IdAlertaAgenda { get; set; }

    public int IdAlertaConfig { get; set; }

    public DateTime? FechaVigencia { get; set; }

    public string? Usuario { get; set; }

    public virtual AlertasAgenda IdAlertaAgendaNavigation { get; set; } = null!;
}
