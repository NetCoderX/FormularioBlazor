using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class CONTROLESEXP
{
    public string? ID { get; set; }

    public string? Id_FecPago { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string Origen { get; set; } = null!;

    public string? Tipo { get; set; }

    public int Copia { get; set; }

    public int Grupo { get; set; }

    public int GrupoObligatorio { get; set; }

    public string? TipoFmt { get; set; }

    public int? CodJoin { get; set; }

    public string? Formula { get; set; }

    public int Invisible { get; set; }
}
