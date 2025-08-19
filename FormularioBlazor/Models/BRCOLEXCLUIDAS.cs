using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BRCOLEXCLUIDAS
{
    public short CodBrowse { get; set; }

    public int SubCodigo { get; set; }

    public string CamposExcluidos { get; set; } = null!;
}
