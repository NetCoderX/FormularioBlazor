using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RTF_Textos
{
    public int IdTexto { get; set; }

    public string Nombre { get; set; } = null!;

    public string Texto { get; set; } = null!;

    public virtual ICollection<RH_ElementosDeTrabajo> RH_ElementosDeTrabajo { get; set; } = new List<RH_ElementosDeTrabajo>();
}
