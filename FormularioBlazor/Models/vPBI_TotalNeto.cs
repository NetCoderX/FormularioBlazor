using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vPBI_TotalNeto
{
    public int IdLegajo { get; set; }

    public int IdPersona { get; set; }

    public string Liquidacion_Nombre { get; set; } = null!;

    public DateTime Liquidacion_Mes { get; set; }

    public string LegajoCodigo { get; set; } = null!;

    public string Apellido_y_Nombres { get; set; } = null!;

    public string CodLegajoNomApe { get; set; } = null!;

    public string? Banco { get; set; }

    public int? Categoria { get; set; }

    public string? Convenio { get; set; }

    public string? Empresa { get; set; }

    public string? Estado_Civil { get; set; }

    public string? Obra_Social { get; set; }

    public DateTime? Fecha_Ingreso { get; set; }

    public short? Modalidad_Contratacion { get; set; }

    public string? Situacion_de_Revista { get; set; }

    public string? Zona { get; set; }

    public string? Lugar_de_Trabajo { get; set; }

    public decimal? Total_Neto { get; set; }

    public decimal? Total_Bruto { get; set; }
}
