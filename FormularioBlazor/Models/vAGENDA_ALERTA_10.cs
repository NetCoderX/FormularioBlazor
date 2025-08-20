using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAGENDA_ALERTA_10
{
    public string? Legajo___Apellido_y_Nombre { get; set; }

    public string? Fecha_base_de_antiguedad { get; set; }

    public decimal? Días_restantes_para_liquidar { get; set; }

    public DateTime? Vencimiento { get; set; }

    public int? IdAlertaAgenda { get; set; }

    public int? IdAlertaConfig { get; set; }

    public int? CodEmp { get; set; }

    public DateTime? FV { get; set; }

    public DateTime? FechaVigencia { get; set; }

    public string? Usuario { get; set; }
}
