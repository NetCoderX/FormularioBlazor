using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class FX_ScriptTransactions
{
    public string IdScript { get; set; } = null!;

    public int? Error { get; set; }

    public string? IdScripts { get; set; }

    public string? Descripcion { get; set; }

    public string? Dependencias { get; set; }

    public byte RecuperarBackup { get; set; }

    public byte MostrarExeFinal { get; set; }
}
