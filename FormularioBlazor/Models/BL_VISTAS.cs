using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_VISTAS
{
    public int IdVista { get; set; }

    public string CodVista { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public short CodEmp { get; set; }

    public virtual EMPRESAS CodEmpNavigation { get; set; } = null!;
}
