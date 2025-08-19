using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_AlternativasCapacitaciones
{
    public int IdAlternativa { get; set; }

    public int IdHabilidad { get; set; }

    public int IdCapacitacion { get; set; }

    public virtual RH_Capacitaciones IdCapacitacionNavigation { get; set; } = null!;

    public virtual RH_Habilidades IdHabilidadNavigation { get; set; } = null!;
}
