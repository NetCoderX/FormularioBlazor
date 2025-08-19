using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_TAREAS
{
    public int IdTarea { get; set; }

    public DateTime Fecha { get; set; }

    public string Descripcion { get; set; } = null!;

    public string UsuOrigen { get; set; } = null!;

    public bool evento { get; set; }

    public string? Comentario { get; set; }

    public int? Intervalo { get; set; }

    public bool? dia1 { get; set; }

    public bool? dia2 { get; set; }

    public bool? dia3 { get; set; }

    public bool? dia4 { get; set; }

    public bool? dia5 { get; set; }

    public bool? dia6 { get; set; }

    public bool? dia7 { get; set; }

    public string? TipoMensual { get; set; }

    public int? dias { get; set; }

    public string? FinPeriodo { get; set; }

    public int? FinRepeticiones { get; set; }

    public int? FinFecha { get; set; }

    public int? IdObjetoElim { get; set; }

    public string? Frecuencia { get; set; }

    public string? Semana { get; set; }

    public string? Semanadia { get; set; }

    public int? IdTareaOrigen { get; set; }

    public bool? generado { get; set; }

    public virtual ICollection<BL_TAREASUSU> BL_TAREASUSU { get; set; } = new List<BL_TAREASUSU>();
}
