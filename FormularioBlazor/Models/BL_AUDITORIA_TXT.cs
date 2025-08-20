using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_AUDITORIA_TXT
{
    public int IdAuditoria { get; set; }

    public string? TextoXml { get; set; }

    public virtual BL_AUDITORIA_CAB IdAuditoriaNavigation { get; set; } = null!;
}
