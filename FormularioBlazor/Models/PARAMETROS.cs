using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class PARAMETROS
{
    public string? VERSION { get; set; }

    public DateTime? FECHAVERSION { get; set; }

    public int? xxxnrotrans { get; set; }

    public string? xxxEMPRESA { get; set; }

    public string? xxxBMP { get; set; }

    public string? MONEDA { get; set; }

    public string? DESCMONEDA { get; set; }

    public short? xxxCODSUC { get; set; }

    public int? LOTE { get; set; }

    public short? DECCANT { get; set; }

    public short? DECPREC { get; set; }

    public short? DECIMPO { get; set; }

    public short? DECCANTTAL { get; set; }

    public short? DIASCHEQUES { get; set; }

    public short? DIASPAGARES { get; set; }

    public byte? TALLES { get; set; }

    public string? DELIMTALLES { get; set; }

    public string? TITDOBLE { get; set; }

    public byte? DOBLEUNIDAD { get; set; }

    public byte? DESPACHOS { get; set; }

    public byte? PARTIDAS { get; set; }

    public byte? SERIES { get; set; }

    public byte? xxxrequerimientos { get; set; }

    public byte? COLCOMPROB { get; set; }

    public int? NROTRANSAUX { get; set; }

    public int? CODCUE2 { get; set; }

    public int? CODCUECOM { get; set; }

    public int? CODCUEVEN { get; set; }

    public int? CODCUEII { get; set; }

    public decimal XXXMINIMOGAN { get; set; }

    public decimal XXXMINIMOIVA { get; set; }

    public decimal? XXXPERCMINIVA { get; set; }

    public string? XXXIVA { get; set; }

    public int? CODINV { get; set; }

    public int? PROXIMOAUT { get; set; }

    public byte? XXXLIQSINPRESEN { get; set; }

    public string? CAJPREFI { get; set; }

    public string? XXXCODCTABCOAUX { get; set; }

    public byte? controlexi { get; set; }

    public byte? CONTROLCRED { get; set; }

    public short? CODTAB { get; set; }

    public short? PLAZO { get; set; }

    public byte? APLAUTOREC { get; set; }

    public byte? APLAUTOOP { get; set; }

    public string? FCFORMATO { get; set; }

    public string? CODCPTCOM { get; set; }

    public string? CODCPTVEN { get; set; }

    public string? TIPOVALUACION { get; set; }

    public string? XXXFMTRETGAN { get; set; }

    public decimal? xxxmaxsinaut { get; set; }

    public string? CENTROA { get; set; }

    public string? CENTROB { get; set; }

    public string? XXXFMTRETIVA { get; set; }

    public string? XXXBONIFICACION1 { get; set; }

    public string? XXXBONIFICACION2 { get; set; }

    public string? XXXBONIFMAX1 { get; set; }

    public string? XXXBONIFMAX2 { get; set; }

    public string? CODLIS { get; set; }

    public byte? FECHAFUTURA { get; set; }

    public string? xxxcodatr { get; set; }

    public string? xxxcodatrval { get; set; }

    public int? XXXNRORETGAN { get; set; }

    public int? XXXNRORETIVA { get; set; }

    public string? XXXNOMBRERET1 { get; set; }

    public string? XXXNOMBRERET2 { get; set; }

    public int? XXXCODCUERET1 { get; set; }

    public int? XXXCODCUERET2 { get; set; }

    public int? XXXCODCUEVENRET1 { get; set; }

    public int? XXXCODCUEVENRET2 { get; set; }

    public int? XXXNRORET1 { get; set; }

    public int? XXXNRORET2 { get; set; }

    public string? XXXFMTRET1 { get; set; }

    public string? XXXFMTRET2 { get; set; }

    public string? xxxcreditoped { get; set; }

    public string? STOCKPED { get; set; }

    public string? xxxautorizaped { get; set; }

    public byte? xxxpedadvertidos { get; set; }

    public int? MAXFECHAENT { get; set; }

    public decimal? xxxmaxsinautnc { get; set; }

    public decimal? DESRECMAS { get; set; }

    public decimal? DESRECMENOS { get; set; }

    public decimal? DESPAGMAS { get; set; }

    public decimal? DESPAGMENOS { get; set; }

    public string? NCPRONTOPAGO { get; set; }

    public string? NDRECARGO { get; set; }

    public decimal? MINNCPRONTOPAGO { get; set; }

    public decimal? MINNDRECARGO { get; set; }

    public byte[]? xxxLOGO { get; set; }

    public string? PREFOCASIONAL { get; set; }

    public int? NUMOCASIONAL { get; set; }

    public string? CONDIOCASIONAL { get; set; }

    public string? LISTAOCASIONAL { get; set; }

    public string? TRATOCASIONAL { get; set; }

    public string? ATRCLIOCASIONAL { get; set; }

    public string? VALATRCLIOCASIONAL { get; set; }

    public string? ATRPROCASIONAL { get; set; }

    public string? VALATRPROCASIONAL { get; set; }

    public short? POSCOLOR { get; set; }

    public short? LARGOCOLOR { get; set; }

    public short? POSMEDIDA { get; set; }

    public short? LARGOMEDIDA { get; set; }

    public string? AMORTIZACION { get; set; }

    public short? CIERREAMOR { get; set; }

    public string? PESO { get; set; }

    public string? VOLUMEN { get; set; }

    public int? MAXFECHAENT2 { get; set; }

    public string? STOCKPED2 { get; set; }

    public byte? xxxpedadvertidos2 { get; set; }

    public string? xxxautorizaped2 { get; set; }

    public string? xxxcodatr2 { get; set; }

    public string? xxxcodatrval2 { get; set; }

    public byte? XXXIMPRIMERG { get; set; }

    public byte? XXXIMPRIMEIVA { get; set; }

    public byte? XXXAVISARG { get; set; }

    public byte? XXXAVISAIVA { get; set; }

    public byte? XXXIMPRIMER1 { get; set; }

    public byte? XXXAVISAR1 { get; set; }

    public byte? XXXIMPRIMER2 { get; set; }

    public byte? XXXAVISAR2 { get; set; }

    public string? XXXIMPRESORAIVA { get; set; }

    public string? XXXIMPRESORAR1 { get; set; }

    public string? XXXIMPRESORAR2 { get; set; }

    public string? XXXIMPRESORARG { get; set; }

    public string? FONT { get; set; }

    public short? TAMANO { get; set; }

    public string? xxxcoditmnc { get; set; }

    public string? xxxcoditmnd { get; set; }

    public string? xxxautorizaped3 { get; set; }

    public string? xxxcodatr3 { get; set; }

    public string? xxxcodatrval3 { get; set; }

    public short? SERVICEPACK { get; set; }

    public decimal? XXXMINIMOSUSS { get; set; }

    public int? XXXNRORETSUSS { get; set; }

    public string? XXXFMTRETSUSS { get; set; }

    public byte? XXXIMPRIMERS { get; set; }

    public byte? XXXAVISARS { get; set; }

    public string? XXXIMPRESORARS { get; set; }

    public byte? CHEQUESSUC { get; set; }

    public byte decimales { get; set; }

    public short? CODTAB2 { get; set; }

    public short? CODTABVAL2 { get; set; }

    public short valprogramada { get; set; }

    public short valsistema { get; set; }

    public byte CIERRE_CON_ERRORES { get; set; }

    public byte INF_CPP { get; set; }

    public byte INF_CPPCIERRE { get; set; }

    public byte INF_LIFO { get; set; }

    public byte INF_FIFO { get; set; }

    public string? LISTA1 { get; set; }

    public string? LISTA2 { get; set; }

    public string? LISTA3 { get; set; }

    public string? LISTA4 { get; set; }

    public string? CODBON { get; set; }

    public decimal? TASAIVA { get; set; }

    public decimal? TASAIVANOI { get; set; }

    public string? AUXILIAR { get; set; }

    public virtual CUENTAS? CODCUE2Navigation { get; set; }

    public virtual CUENTAS? CODCUECOMNavigation { get; set; }

    public virtual CUENTAS? CODCUEIINavigation { get; set; }

    public virtual CUENTAS? CODCUEVENNavigation { get; set; }

    public virtual TABLAS? CODTAB2Navigation { get; set; }

    public virtual TABLAS? CODTABVAL2Navigation { get; set; }
}
