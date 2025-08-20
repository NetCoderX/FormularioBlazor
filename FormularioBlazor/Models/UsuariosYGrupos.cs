using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class UsuariosYGrupos
{
    public string? Clave { get; set; }

    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Nombre { get; set; }

    public string Tipo { get; set; } = null!;

    public short CodEmp { get; set; }
}
