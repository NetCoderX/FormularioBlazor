using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AU_RECONSTRUCCIONES
{
    public int IdRec { get; set; }

    public string? RecCodFormato { get; set; }

    public DateTime? RecFecha { get; set; }

    public DateTime? RecFechaGen { get; set; }

    public string? RecObservacion { get; set; }
}
