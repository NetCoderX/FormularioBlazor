using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_PERSONALEVENTUAL
{
    public int idPersonalEventual { get; set; }

    public string CUIL { get; set; } = null!;

    public string? Apellido { get; set; }

    public string? Nombre { get; set; }

    public string? Categoria { get; set; }

    public DateTime? FecIngreso { get; set; }

    public string? Domicilio { get; set; }

    public DateTime? FecNacimiento { get; set; }

    public string? Tarea { get; set; }

    public DateTime? FecEgreso { get; set; }

    public string? Localidad { get; set; }

    public string? Nacionalidad { get; set; }

    public int CategoriaProfesional { get; set; }

    public int PuestoDesempeniado { get; set; }
}
