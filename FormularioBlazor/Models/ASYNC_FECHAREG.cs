using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ASYNC_FECHAREG
{
    public int IdProceso { get; set; }

    public int IdLegajo { get; set; }

    public int Id { get; set; }

    public DateTime? FechaReg { get; set; }

    public virtual ASYNC_PROCESOS IdProcesoNavigation { get; set; } = null!;
}
