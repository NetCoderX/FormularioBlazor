using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAUDI_PERSONAS
{
    public int IdPersona { get; set; }

    public int? IdNacionalidad { get; set; }

    public int? IdEstado { get; set; }

    public int? IdProvincia { get; set; }

    public string? Nombres_y_Apellido { get; set; }

    public string? Persona { get; set; }

    public string? ApellidoCasada { get; set; }

    public string? Documento { get; set; }

    public string? CUIL { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Estado_Civil { get; set; }

    public string? Sexo { get; set; }

    public string? Domicilio { get; set; }

    public string? Localidad { get; set; }

    public string? Provincia { get; set; }

    public string? Teléfono { get; set; }

    public string? Email { get; set; }

    public DateTime? Fecha_de_Nacimiento { get; set; }
}
