using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ASYNC_PROCESOS
{
    public int IdProceso { get; set; }

    public bool Activo { get; set; }

    public string ComputerName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public DateTime FechaHora { get; set; }

    public virtual ICollection<ASYNC_FECHAREG> ASYNC_FECHAREG { get; set; } = new List<ASYNC_FECHAREG>();

    public virtual ICollection<ASYNC_FECHAREG_SUSPENSION> ASYNC_FECHAREG_SUSPENSION { get; set; } = new List<ASYNC_FECHAREG_SUSPENSION>();

    public virtual ICollection<ASYNC_NOVEDADES> ASYNC_NOVEDADES { get; set; } = new List<ASYNC_NOVEDADES>();

    public virtual ICollection<ASYNC_VARIABLES> ASYNC_VARIABLES { get; set; } = new List<ASYNC_VARIABLES>();
}
