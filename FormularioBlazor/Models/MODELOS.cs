using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class MODELOS
{
    public short CODMOD { get; set; }

    public string DESCRIPCION { get; set; } = null!;

    public short CODPROG { get; set; }

    public byte? PREDETERMINADO { get; set; }

    public virtual ICollection<MODELIN> MODELIN { get; set; } = new List<MODELIN>();
}
