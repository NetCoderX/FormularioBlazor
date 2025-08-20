using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAGENDA_ALERTA
{
    public int IdAlertaAgenda { get; set; }

    public int IdAlertaConfig { get; set; }

    public int IdTipoAlerta { get; set; }

    public string TipoNombre { get; set; } = null!;

    public int IdSubTipoAlerta { get; set; }

    public string SubTipoNombre { get; set; } = null!;

    public int Clave1 { get; set; }

    public int Clave2 { get; set; }

    public int Clave3 { get; set; }

    public DateTime Fecha { get; set; }

    public string? TipoFecha { get; set; }

    public int? CodEmp { get; set; }

    public DateTime? FechaVigencia { get; set; }

    public string? Usuario { get; set; }

    public short? CodEmpConfig { get; set; }
}
