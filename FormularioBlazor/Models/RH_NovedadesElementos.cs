using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_NovedadesElementos
{
    public int IdDetalle { get; set; }

    public int IdOcurrencia { get; set; }

    public int IdElemento { get; set; }

    public string? Identificador { get; set; }

    public int Cantidad { get; set; }

    public DateTime? FecDevolucion { get; set; }

    public DateTime? FecReposicion { get; set; }

    public bool? TieneDevolucion { get; set; }

    public short? Repuesta { get; set; }

    public short? Devuelta { get; set; }

    public int? IdOcurrenciaEntrega { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public int? IdPersona { get; set; }
}
