using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Documentos
{
    public int IdDocumento { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? PalabrasClaves { get; set; }

    public bool TieneVencimiento { get; set; }

    public string Tipo { get; set; } = null!;

    public short? CodEmp { get; set; }

    public bool? Adhoc { get; set; }

    public virtual ICollection<RH_AlternativasDocumentos> RH_AlternativasDocumentos { get; set; } = new List<RH_AlternativasDocumentos>();
}
