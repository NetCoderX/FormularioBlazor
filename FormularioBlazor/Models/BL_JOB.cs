using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_JOB
{
    public int Tarea { get; set; }

    public string? Descripcion { get; set; }

    public short CodEmp { get; set; }

    public bool Habilitada { get; set; }

    public string Frecuencia { get; set; } = null!;

    public string? Opciones { get; set; }
}
