using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAGENDA_ALERTA_12
{
    public string? Persona___Apellido_y_Nombre { get; set; }

    public string Puesto { get; set; } = null!;

    public string? ElementoDeTrabajo { get; set; }

    public string? PróximaEntrega { get; set; }

    public int IdAlertaAgenda { get; set; }

    public int IdAlertaConfig { get; set; }

    public int? CodEmp { get; set; }

    public DateTime FV { get; set; }

    public DateTime? FechaVigencia { get; set; }

    public string? Usuario { get; set; }
}
