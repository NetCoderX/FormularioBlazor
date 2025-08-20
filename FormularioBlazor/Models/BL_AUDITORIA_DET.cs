using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_AUDITORIA_DET
{
    public int Id { get; set; }

    public int IdAuditoria { get; set; }

    public int IdTabla { get; set; }

    public string Campo { get; set; } = null!;

    public int? Registro { get; set; }

    public int? RegistroOrden { get; set; }

    public string? New_Valor { get; set; }

    public int? New_IdValor { get; set; }

    public string? New_Codigo { get; set; }

    public string? New_Descripcion { get; set; }

    public string? Old_Valor { get; set; }

    public int? Old_IdValor { get; set; }

    public string? Old_Codigo { get; set; }

    public string? Old_Descripcion { get; set; }

    public string? ABM { get; set; }

    public byte? TipoDato { get; set; }

    public byte ValorModificado { get; set; }

    public virtual BL_AUDITORIA_CAB IdAuditoriaNavigation { get; set; } = null!;
}
