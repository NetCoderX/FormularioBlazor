using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AUX_NOTIFICACION
{
    public int Orden { get; set; }

    public short Codemp { get; set; }

    public int IdOcurrencia { get; set; }

    public string? CODSUCESO { get; set; }

    public string? DESCRIPCION { get; set; }

    public string LEGAJO { get; set; } = null!;

    public string? NOMBRE { get; set; }

    public bool? notificado { get; set; }

    public DateTime? FecPrevNot { get; set; }

    public DateTime? FecNotifJustif { get; set; }

    public string? Comentario { get; set; }

    public byte[]? TIMESTAMP { get; set; }
}
