using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_NovedadesCancelaciones_Anexo
{
    public int? IdOcurrencia { get; set; }

    public string? Tipo { get; set; }

    public int? IdCapEva { get; set; }

    public byte[] TimeStamp { get; set; } = null!;
}
