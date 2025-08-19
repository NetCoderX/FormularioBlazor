using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_DOCSTEXTO
{
    public int IdDocTexto { get; set; }

    public string Descripcion { get; set; } = null!;

    public byte[] Texto { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string CodDocTexto { get; set; } = null!;

    public bool EsDeOrganigrama { get; set; }

    public virtual ICollection<BL_SUCESOS> BL_SUCESOS { get; set; } = new List<BL_SUCESOS>();
}
