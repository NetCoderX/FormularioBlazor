using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_TEMPVALORESREGISTRADOS
{
    public int IdLegajo { get; set; }

    public string MesLiq { get; set; } = null!;

    public string CodLiq { get; set; } = null!;

    public decimal? ValorAcum1 { get; set; }

    public decimal? ValorAcum2 { get; set; }

    public decimal? ValorAcum3 { get; set; }

    public decimal? ValorAcum4 { get; set; }

    public decimal? ValorAcum5 { get; set; }

    public string? ValorAtr1 { get; set; }

    public string? DescAtr1 { get; set; }

    public string? ValorAtr2 { get; set; }

    public string? DescAtr2 { get; set; }

    public string? ValorAtr3 { get; set; }

    public string? DescAtr3 { get; set; }

    public string? ValorAtr4 { get; set; }

    public string? DescAtr4 { get; set; }

    public string? ValorAtr5 { get; set; }

    public string? DescAtr5 { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public decimal? ValorVar1 { get; set; }

    public decimal? ValorVar2 { get; set; }

    public decimal? ValorVar3 { get; set; }

    public decimal? ValorVar4 { get; set; }

    public decimal? ValorVar5 { get; set; }
}
