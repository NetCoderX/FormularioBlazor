using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAGENDA_ALERTA_6
{
    public string? Legajo___Apellido_y_Nombre { get; set; }

    public string Puesto { get; set; } = null!;

    public string? Modalidad_de_contratación { get; set; }

    public string? Ingreso { get; set; }

    public DateTime Vencimiento { get; set; }

    public int IdAlertaAgenda { get; set; }

    public int IdAlertaConfig { get; set; }

    public int? CodEmp { get; set; }

    public DateTime FV { get; set; }

    public DateTime? FechaVigencia { get; set; }

    public string? Usuario { get; set; }
}
