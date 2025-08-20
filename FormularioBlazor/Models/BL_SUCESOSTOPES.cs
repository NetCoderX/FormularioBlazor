using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_SUCESOSTOPES
{
    public int IdSuceso { get; set; }

    public string? codAtrVal { get; set; }

    public decimal? TopeNovedad { get; set; }

    public decimal? TopeMes { get; set; }

    public decimal? TopeAnio { get; set; }

    public int? IdConvenio { get; set; }
}
