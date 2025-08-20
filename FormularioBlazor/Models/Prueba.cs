using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class Prueba
{
    public decimal? Importe { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Cadena { get; set; }

    public string? Number_dec { get; set; }

    public string? Number_mil { get; set; }

    public string? Currency_dec { get; set; }

    public string? Currency_mil { get; set; }
}
