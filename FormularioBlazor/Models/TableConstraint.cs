using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class TableConstraint
{
    public string Referencing_Object_name { get; set; } = null!;

    public string? referencing_column_Name { get; set; }

    public string Referenced_Object_name { get; set; } = null!;

    public string? Referenced_Column_Name { get; set; }

    public string Constraint_name { get; set; } = null!;
}
