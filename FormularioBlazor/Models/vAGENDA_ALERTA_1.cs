using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAGENDA_ALERTA_1
{
    public string? Tipo { get; set; }

    public string? Plan { get; set; }

    public string? Tipo_de_Fecha { get; set; }

    public string? Fecha { get; set; }

    public int IdAlertaAgenda { get; set; }

    public int IdAlertaConfig { get; set; }

    public int? CodEmp { get; set; }

    public DateTime FV { get; set; }

    public DateTime? FechaVigencia { get; set; }

    public string? Usuario { get; set; }
}
