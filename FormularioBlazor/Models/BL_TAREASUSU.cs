using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_TAREASUSU
{
    public int IdTarea { get; set; }

    public string UsuDestino { get; set; } = null!;

    public bool Fin { get; set; }

    public virtual BL_TAREAS IdTareaNavigation { get; set; } = null!;
}
