using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AU_CONFIG
{
    public int IdAud { get; set; }

    public string CodObjeto { get; set; } = null!;

    public bool? Activo { get; set; }

    public DateTime? DesdeAct { get; set; }

    public DateTime? HastaAct { get; set; }

    public string? Tabla { get; set; }

    public bool? Subtabla { get; set; }

    public string? CampoLogico { get; set; }

    public string? CamposAMostrar { get; set; }

    public string? JoinsACompletar { get; set; }

    public string? Alias { get; set; }

    public string? ObjRelacional { get; set; }

    public string? FieldRelacional { get; set; }
}
