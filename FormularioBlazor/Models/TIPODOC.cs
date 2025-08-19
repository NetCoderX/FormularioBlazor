using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class TIPODOC
{
    public string CODDOC { get; set; } = null!;

    public string DESCRIPCION { get; set; } = null!;

    public byte? VALIDACION { get; set; }

    public byte NoExisteEnBASCS { get; set; }

    public virtual ICollection<BL_FAMILIARES> BL_FAMILIARES { get; set; } = new List<BL_FAMILIARES>();

    public virtual ICollection<BL_PERSONAS> BL_PERSONAS { get; set; } = new List<BL_PERSONAS>();
}
