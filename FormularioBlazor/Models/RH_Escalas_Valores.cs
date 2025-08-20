using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Escalas_Valores
{
    public int IdEscala { get; set; }

    public int IdEscalaValor { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Valor { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual RH_Escalas IdEscalaNavigation { get; set; } = null!;
}
