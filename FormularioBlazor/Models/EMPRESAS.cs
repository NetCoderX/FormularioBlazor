using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class EMPRESAS
{
    public short CODEMP { get; set; }

    public string NOMBRE { get; set; } = null!;

    public string? DOMICILIO { get; set; }

    public string? DOMICILIO2 { get; set; }

    public string? LOCALIDAD { get; set; }

    public string? CODPOS { get; set; }

    public string? CODPRV { get; set; }

    public string? CODPAIS { get; set; }

    public string? TELEFONO { get; set; }

    public string? FAX { get; set; }

    public string? CODDOC { get; set; }

    public string? NRODOC1 { get; set; }

    public string? CONTACT1 { get; set; }

    public string? CONTACT2 { get; set; }

    public byte[] TIMESTAMP { get; set; } = null!;

    public byte[]? logo { get; set; }

    public string? IVA { get; set; }

    public decimal? MINIMOGAN { get; set; }

    public int? NRORETGAN { get; set; }

    public string? FMTRETGAN { get; set; }

    public string? IMPRESORARG { get; set; }

    public byte? IMPRIMERG { get; set; }

    public byte? AVISARG { get; set; }

    public int? NRORETIVA { get; set; }

    public string? FMTRETIVA { get; set; }

    public string? IMPRESORAIVA { get; set; }

    public byte? IMPRIMEIVA { get; set; }

    public byte? AVISAIVA { get; set; }

    public decimal? PERCMINIVA { get; set; }

    public decimal? MINIMOIVA { get; set; }

    public string? NOMBRERET1 { get; set; }

    public int? CODCUERET1 { get; set; }

    public int? CODCUEVENRET1 { get; set; }

    public string? FMTRET1 { get; set; }

    public int? NRORET1 { get; set; }

    public string? IMPRESORAR1 { get; set; }

    public byte? IMPRIMER1 { get; set; }

    public byte? AVISAR1 { get; set; }

    public string? NOMBRERET2 { get; set; }

    public int? CODCUERET2 { get; set; }

    public int? CODCUEVENRET2 { get; set; }

    public string? FMTRET2 { get; set; }

    public int? NRORET2 { get; set; }

    public string? IMPRESORAR2 { get; set; }

    public byte? IMPRIMER2 { get; set; }

    public byte? AVISAR2 { get; set; }

    public decimal? MINIMOSUSS { get; set; }

    public int? NRORETSUSS { get; set; }

    public string? FMTRETSUSS { get; set; }

    public string? IMPRESORARS { get; set; }

    public byte? IMPRIMERS { get; set; }

    public byte? AVISARS { get; set; }

    public byte? LIQSINPRESEN { get; set; }

    public string? codctabcoaux { get; set; }

    public short? codsuccen { get; set; }

    public DateTime? FEC_VALORIZACION { get; set; }

    public decimal PERCMINGAN { get; set; }

    public DateTime? fec_fin_val { get; set; }

    public int? TIPO { get; set; }

    public short? COPIASRG { get; set; }

    public short? COPIASRI { get; set; }

    public string TIPOCOPIARG { get; set; } = null!;

    public string TIPOCOPIARI { get; set; } = null!;

    public string? ACTIVIDAD { get; set; }

    public string? CAJAPREV { get; set; }

    public string? CAJAPREVNRO { get; set; }

    public string? NROINSCRRNIC { get; set; }

    public byte? TIPOSIJP { get; set; }

    public int? IdProvincia { get; set; }

    public virtual ICollection<BL_LEGAJOS> BL_LEGAJOS { get; set; } = new List<BL_LEGAJOS>();

    public virtual ICollection<BL_NOVEDADES> BL_NOVEDADES { get; set; } = new List<BL_NOVEDADES>();

    public virtual ICollection<BL_NOVEDADES_SUSPENSION> BL_NOVEDADES_SUSPENSION { get; set; } = new List<BL_NOVEDADES_SUSPENSION>();

    public virtual ICollection<BL_USUEMPRESAS> BL_USUEMPRESAS { get; set; } = new List<BL_USUEMPRESAS>();

    public virtual ICollection<BL_VISTAS> BL_VISTAS { get; set; } = new List<BL_VISTAS>();

    public virtual ICollection<USUARIOS> USUARIOS { get; set; } = new List<USUARIOS>();
}
