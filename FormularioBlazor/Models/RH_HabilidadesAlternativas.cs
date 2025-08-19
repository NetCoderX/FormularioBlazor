using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_HabilidadesAlternativas
{
    public int IdHabilidad { get; set; }

    public int IdAlternativa { get; set; }

    public string? Descripcion { get; set; }

    public virtual RH_Habilidades IdHabilidadNavigation { get; set; } = null!;
}
