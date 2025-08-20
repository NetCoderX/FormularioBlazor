using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ASYNC_VARIABLES
{
    public int Id { get; set; }

    public int IdProceso { get; set; }

    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Valor { get; set; }

    public virtual ASYNC_PROCESOS IdProcesoNavigation { get; set; } = null!;
}
