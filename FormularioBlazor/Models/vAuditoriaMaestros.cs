using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAuditoriaMaestros
{
    public string? Operacion { get; set; }

    public byte? IdOperacion { get; set; }

    public string? Maestro { get; set; }

    public int? IdMaestro { get; set; }

    public string? Entidad { get; set; }

    public int IdDato { get; set; }

    public int IdAud { get; set; }

    public int IdCampo { get; set; }

    public int IdMovimiento { get; set; }

    public string? CodObjeto { get; set; }

    public int? IdDatoAnterior { get; set; }

    public string? Valor { get; set; }

    public string? NuevoValor { get; set; }

    public string? CodCampoLogico { get; set; }

    public bool AudSubTabla { get; set; }

    public DateTime? fecha { get; set; }

    public string? usuario { get; set; }

    public string? NombreMaquina { get; set; }

    public string? campo { get; set; }

    public string? descripcion { get; set; }

    public string? ObjetoBase { get; set; }

    public string? CampoCod { get; set; }
}
