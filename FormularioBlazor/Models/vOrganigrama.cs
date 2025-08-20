using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vOrganigrama
{
    public int? Legajo_ID { get; set; }

    public string? Legajo_Codigo { get; set; }

    public string? Legajo_Nombre { get; set; }

    public string? Puesto_Codigo { get; set; }

    public string? Puesto_Nombre { get; set; }

    public int? Puesto_Id { get; set; }
}
