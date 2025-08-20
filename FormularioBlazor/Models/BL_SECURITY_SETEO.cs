using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_SECURITY_SETEO
{
    public int IdSeteo { get; set; }

    public int IdTipo { get; set; }

    public int IdPermiso { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdGrupo { get; set; }

    public short Permitido { get; set; }

    public int? IdLegajo { get; set; }

    public string? CodAtr { get; set; }

    public string? CodAtrVal { get; set; }

    public string? CenPrefi { get; set; }

    public string? CodCen { get; set; }

    public short CodEmp { get; set; }

    public bool? PermisoModificar { get; set; }

    public int? IdSuceso { get; set; }

    public string? CodVariable { get; set; }

    public int? IdConcepto { get; set; }

    public virtual ATRIBUTOSVAL? ATRIBUTOSVAL { get; set; }

    public virtual BL_SECURITY_PERMISOS BL_SECURITY_PERMISOS { get; set; } = null!;

    public virtual CENTROSAP? CENTROSAP { get; set; }

    public virtual BL_SECURITY_GRUPOS? IdGrupoNavigation { get; set; }

    public virtual BL_LEGAJOS? IdLegajoNavigation { get; set; }

    public virtual BL_SECURITY_USUARIOS? IdUsuarioNavigation { get; set; }
}
