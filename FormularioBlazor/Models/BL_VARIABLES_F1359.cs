using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_VARIABLES_F1359
{
    public int Id { get; set; }

    public string RegistroTipo { get; set; } = null!;

    public string RegistroDesc { get; set; } = null!;

    public string Campo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Obligatorio { get; set; }

    public int? IdGrupo { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int Longitud { get; set; }

    public string? Version { get; set; }

    public string? Excepcion { get; set; }
}
