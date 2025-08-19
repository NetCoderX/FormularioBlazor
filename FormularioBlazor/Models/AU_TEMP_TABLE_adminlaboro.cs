using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AU_TEMP_TABLE_adminlaboro
{
    public string Legajo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int IdDato { get; set; }

    public int IdAud { get; set; }

    public int IdCampo { get; set; }

    public int IdMovimiento { get; set; }

    public string? CodObjeto { get; set; }

    public int? IdDatoAnterior { get; set; }

    public string Valor { get; set; } = null!;

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
