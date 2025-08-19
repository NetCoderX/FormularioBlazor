using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_VARIABLESTOPES
{
    public int IdVariable { get; set; }

    public string CodAtrVal { get; set; } = null!;

    public decimal? TopeNovedad { get; set; }

    public decimal? TopeMes { get; set; }

    public decimal? TopeAnio { get; set; }
}
