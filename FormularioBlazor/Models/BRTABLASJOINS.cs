using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BRTABLASJOINS
{
    public short CODBROWSE { get; set; }

    public int CODJOIN { get; set; }

    public string? TEXTJOIN { get; set; }

    public virtual BRTABLAS CODBROWSENavigation { get; set; } = null!;
}
