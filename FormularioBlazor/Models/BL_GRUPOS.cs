using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_GRUPOS
{
    public int IdGrupo { get; set; }

    public int Codigo { get; set; }

    public string Descripcion { get; set; } = null!;

    public string TipoGrupo { get; set; } = null!;

    public string? Formula { get; set; }

    public int? IdVariable { get; set; }

    public bool SoloExportacionTxt { get; set; }

    public virtual ICollection<BL_GRUPOSDEP> BL_GRUPOSDEP { get; set; } = new List<BL_GRUPOSDEP>();
}
