using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vPuestosEmpresas
{
    public int IdPuesto { get; set; }

    public string? Descripcion { get; set; }

    public string? Nombre { get; set; }

    public int? IdDocAsociado { get; set; }

    public int? IdVista { get; set; }

    public string CodEmp { get; set; } = null!;

    public int? IdPuestoSuperior { get; set; }

    public string? IdDescripcionPuestoSuperior { get; set; }

    public string? NombrePuestoSuperior { get; set; }
}
