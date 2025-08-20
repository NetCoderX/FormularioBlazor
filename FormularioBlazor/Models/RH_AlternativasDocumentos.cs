using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_AlternativasDocumentos
{
    public int IdAlternativa { get; set; }

    public int IdHabilidad { get; set; }

    public int IdDocumento { get; set; }

    public virtual RH_Documentos IdDocumentoNavigation { get; set; } = null!;

    public virtual RH_Habilidades IdHabilidadNavigation { get; set; } = null!;
}
