using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_ACUMULADORES
{
    public int IdAcumulador { get; set; }

    public string CodAcumulador { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public byte MayorValor { get; set; }

    public string MesesAConsiderar { get; set; } = null!;

    public bool IncluirLiqAct { get; set; }

    public string AniosAConsiderar { get; set; } = null!;

    public bool IncluirLiqAntActual { get; set; }

    public byte CargaInicial { get; set; }

    public byte IncHaberes { get; set; }

    public byte IncRetenciones { get; set; }

    public byte IncAsigFam { get; set; }

    public byte IncRedondeo { get; set; }

    public byte IncContribuciones { get; set; }

    public byte ConsideraImpProrrateados { get; set; }

    public bool UltimaLiqMesAct { get; set; }

    public bool UltimaLiqMesAnt { get; set; }

    public string TipoFecMesActual { get; set; } = null!;
}
