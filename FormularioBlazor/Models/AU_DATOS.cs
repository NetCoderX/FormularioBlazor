using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AU_DATOS
{
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
}
