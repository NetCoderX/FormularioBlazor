using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAutogestion_RecibosDetalle
{
    public string? Clave { get; set; }

    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public int IdPersona { get; set; }

    public string Apellido_y_Nombres { get; set; } = null!;

    public string? Firmado { get; set; }

    public string? Visualizado { get; set; }

    public string? Observación { get; set; }

    public string? Liquidación { get; set; }

    public DateTime? Fecha_Ingreso { get; set; }

    public string? Banco { get; set; }

    public string? Obra_Social { get; set; }

    public string? Estado_Civil { get; set; }

    public string? Modalidad_Contratación { get; set; }

    public string? Situación_de_Revista { get; set; }

    public string? Zona { get; set; }

    public string? Categoria { get; set; }

    public string? Convenio { get; set; }

    public string? Empresa { get; set; }
}
