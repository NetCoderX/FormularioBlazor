using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RHV_VistaEvidencias
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool TieneVencimiento { get; set; }

    public bool Adhoc { get; set; }

    public short? CodEmp { get; set; }
}
