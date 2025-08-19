using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAGENDA_ALERTA_7
{
    public string? Legajo___Apellido_y_Nombre { get; set; }

    public string Puesto { get; set; } = null!;

    public string? Nacimiento { get; set; }

    public short? Edad { get; set; }

    public DateTime? Jubilación { get; set; }

    public int IdAlertaAgenda { get; set; }

    public int IdAlertaConfig { get; set; }

    public int? CodEmp { get; set; }

    public DateTime FV { get; set; }

    public DateTime? FechaVigencia { get; set; }

    public string? Usuario { get; set; }
}
