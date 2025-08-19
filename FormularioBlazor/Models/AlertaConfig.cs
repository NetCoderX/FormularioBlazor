using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AlertaConfig
{
    public int IdAlerta { get; set; }

    public int? IdSubTipoAlerta { get; set; }

    public string? Descripcion { get; set; }

    public int? Aviso { get; set; }

    public bool? Anticipacion { get; set; }

    public int? DiasDeAnticipacion { get; set; }

    public string? GrupoDeAnalisis { get; set; }

    public string? Mensaje_De { get; set; }

    public string? Mensaje_Para { get; set; }

    public string? Mensaje_ParaTexto { get; set; }

    public string? Mensaje_CC { get; set; }

    public string? Mensaje_CCTexto { get; set; }

    public string? Mensaje_Asunto { get; set; }

    public string? Mensaje_Texto { get; set; }

    public bool Habilitada { get; set; }

    public short? CodEmp { get; set; }
}
