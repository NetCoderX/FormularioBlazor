using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_AUDITORIA_CAB
{
    public int IdAuditoria { get; set; }

    public int? IdOcurrencia { get; set; }

    public DateTime Fecha { get; set; }

    public short? CodProg { get; set; }

    public string? ABM { get; set; }

    public string? Origen { get; set; }

    public string? DescProg { get; set; }

    public string? Usuario { get; set; }

    public string? ComputerName { get; set; }

    public string? Vigencia { get; set; }

    public short? CodEmp { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? CodAtr { get; set; }

    public string? CodAtrVal { get; set; }

    public int? IdConvenio { get; set; }

    public int? IdLegajo { get; set; }

    public int? IdPersona { get; set; }

    public int? IdFamiliar { get; set; }

    public int? IdConcepto { get; set; }

    public int? IdVariable { get; set; }

    public int? IdAcumulador { get; set; }

    public string? PeriodoGanancia { get; set; }

    public virtual ICollection<BL_AUDITORIA_DET> BL_AUDITORIA_DET { get; set; } = new List<BL_AUDITORIA_DET>();

    public virtual BL_AUDITORIA_TXT? BL_AUDITORIA_TXT { get; set; }
}
