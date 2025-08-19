using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAutogestion_Personas
{
    public int IdPersona { get; set; }

    public string PersonaCodigo { get; set; } = null!;

    public string NombreCompleto { get; set; } = null!;

    public string? Nombres { get; set; }

    public string? Apellido { get; set; }

    public string? ApellidoCasada { get; set; }

    public string? DomicilioCalle { get; set; }

    public string? DomicilioNro { get; set; }

    public string? DomicilioPiso { get; set; }

    public string? DomicilioDepto { get; set; }

    public string? DomicilioLoc { get; set; }

    public string? DomicilioCodPos { get; set; }

    public string? DomicilioProv { get; set; }

    public string? DNI { get; set; }

    public string? CUIL { get; set; }

    public string? Nacionalidad { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Sexo { get; set; }

    public string? FecNacimiento { get; set; }

    public string? Telefono { get; set; }

    public string? EmailPersonal { get; set; }
}
