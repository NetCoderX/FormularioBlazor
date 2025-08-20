using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BRTABLASCOLSCASE
{
    public short CODBROWSE { get; set; }

    public int CODCASE { get; set; }

    public string? TEXTCASE { get; set; }

    public virtual BRTABLAS CODBROWSENavigation { get; set; } = null!;
}
