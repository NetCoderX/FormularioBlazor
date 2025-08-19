using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class SIRADIG_FamiliarGastoEducacion
{
    public int IdPersona { get; set; }

    public short tipoDocFamiliar { get; set; }

    public string numeroDocFamiliar { get; set; } = null!;

    public string apellidoNombreFamiliar { get; set; } = null!;

    public short parentescoFamiliar { get; set; }

    public short porcentajeDedFamiliar { get; set; }

    public int Periodo { get; set; }
}
