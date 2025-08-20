using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vPBI_RecibosDetalle
{
    public string? Clave { get; set; }

    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public int IdPersona { get; set; }

    public string Apellido_y_Nombres { get; set; } = null!;

    public string? Liquidacion { get; set; }

    public DateTime? Fecha_Ingreso { get; set; }

    public string? Banco { get; set; }

    public string? Obra_Social { get; set; }

    public string? Estado_Civil { get; set; }

    public short? Modalidad_Contratacion { get; set; }

    public string? Situacion_de_Revista { get; set; }

    public string? Zona { get; set; }

    public int? Categoria { get; set; }

    public string? Convenio { get; set; }

    public string? Empresa { get; set; }
}
