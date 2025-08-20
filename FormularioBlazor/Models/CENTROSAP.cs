using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class CENTROSAP
{
    public string CENPREFI { get; set; } = null!;

    public string CODCEN { get; set; } = null!;

    public string NOMBRE { get; set; } = null!;

    public byte[] TIMESTAMP { get; set; } = null!;

    public byte? ADMNEGOCIOS { get; set; }

    public byte NoExisteEnBASCS { get; set; }

    public int IdCentroAp { get; set; }

    public virtual ICollection<BL_SECURITY_SETEO> BL_SECURITY_SETEO { get; set; } = new List<BL_SECURITY_SETEO>();
}
