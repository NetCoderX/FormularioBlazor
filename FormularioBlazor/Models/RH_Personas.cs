using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Personas
{
    public int IdPersona { get; set; }

    public string Codigo { get; set; } = null!;

    public string NombreCompleto { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string ApellidoCasada { get; set; } = null!;

    public string DomicilioCalle { get; set; } = null!;

    public string DomicilioNro { get; set; } = null!;

    public string DomicilioPiso { get; set; } = null!;

    public string DomicilioDepto { get; set; } = null!;

    public string DomicilioLoc { get; set; } = null!;

    public string DomicilioCodPos { get; set; } = null!;

    public string DomicilioProv { get; set; } = null!;

    public string DNI { get; set; } = null!;

    public string CUIL { get; set; } = null!;

    public string Nacionalidad { get; set; } = null!;

    public string EstadoCivil { get; set; } = null!;

    public string Sexo { get; set; } = null!;

    public DateTime FecNacimiento { get; set; }

    public string Telefono { get; set; } = null!;

    public string EmailPersonal { get; set; } = null!;

    public short Empresa { get; set; }

    public string Legajo { get; set; } = null!;

    public string Puesto { get; set; } = null!;

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaEgreso { get; set; }

    public byte[]? Foto { get; set; }
}
