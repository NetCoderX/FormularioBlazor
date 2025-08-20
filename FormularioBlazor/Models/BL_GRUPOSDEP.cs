using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_GRUPOSDEP
{
    public int IdGrupo { get; set; }

    public int IdGrupoDep { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual BL_GRUPOS IdGrupoDepNavigation { get; set; } = null!;
}
