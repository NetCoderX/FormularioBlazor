using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_NovedadesEvaluaciones
{
    public int? IdOcurrencia { get; set; }

    public DateTime? FecEvaluacion { get; set; }

    public int? IdCapacitacion { get; set; }

    public int? IdSuceso { get; set; }

    public int? IdPlanEva { get; set; }

    public short? Etapa { get; set; }

    public int? IdEvaluacion { get; set; }

    public int? IdFormulario { get; set; }

    public int? IdEvaluador { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdComentariosEvaluador { get; set; }

    public int? IdComentariosEvaluado { get; set; }

    public int? IdConclusion { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public byte? Aprobado { get; set; }

    public DateTime? Vencimiento { get; set; }

    public int? IdPlanCap { get; set; }

    public int? IdPersona { get; set; }

    public int? IdOcurrenciaCapacitacion { get; set; }

    public byte[]? DocAsociado { get; set; }

    public string? DescDocAsociado { get; set; }

    public virtual RH_Capacitaciones? IdCapacitacionNavigation { get; set; }

    public virtual RTF_Textos? IdComentariosEvaluadoNavigation { get; set; }

    public virtual RTF_Textos? IdComentariosEvaluadorNavigation { get; set; }

    public virtual RTF_Textos? IdConclusionNavigation { get; set; }

    public virtual RH_Evaluaciones? IdEvaluacionNavigation { get; set; }

    public virtual BL_PERSONAS? IdEvaluadorNavigation { get; set; }

    public virtual RH_Formularios? IdFormularioNavigation { get; set; }

    public virtual BL_PERSONAS? IdPersonaNavigation { get; set; }
}
