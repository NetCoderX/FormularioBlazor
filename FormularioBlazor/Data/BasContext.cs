using System;
using System.Collections.Generic;
using Autogestion.Models;
using Microsoft.EntityFrameworkCore;

namespace Autogestion.Data;

public partial class BasContext : DbContext
{
    public BasContext()
    {
    }

    public BasContext(DbContextOptions<BasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ASYNC_FECHAREG> ASYNC_FECHAREG { get; set; }

    public virtual DbSet<ASYNC_FECHAREG_SUSPENSION> ASYNC_FECHAREG_SUSPENSION { get; set; }

    public virtual DbSet<ASYNC_NOVEDADES> ASYNC_NOVEDADES { get; set; }

    public virtual DbSet<ASYNC_PROCESOS> ASYNC_PROCESOS { get; set; }

    public virtual DbSet<ASYNC_VARIABLES> ASYNC_VARIABLES { get; set; }

    public virtual DbSet<ATRIBUTOS> ATRIBUTOS { get; set; }

    public virtual DbSet<ATRIBUTOSEMP> ATRIBUTOSEMP { get; set; }

    public virtual DbSet<ATRIBUTOSVAL> ATRIBUTOSVAL { get; set; }

    public virtual DbSet<AUX_ASIENTOS> AUX_ASIENTOS { get; set; }

    public virtual DbSet<AUX_LINASIENTOS> AUX_LINASIENTOS { get; set; }

    public virtual DbSet<AUX_NOTIFICACION> AUX_NOTIFICACION { get; set; }

    public virtual DbSet<AU_CAMPOS> AU_CAMPOS { get; set; }

    public virtual DbSet<AU_CODIGOSFORMATOS> AU_CODIGOSFORMATOS { get; set; }

    public virtual DbSet<AU_CONFIG> AU_CONFIG { get; set; }

    public virtual DbSet<AU_DATOS> AU_DATOS { get; set; }

    public virtual DbSet<AU_MOVIMIENTOS> AU_MOVIMIENTOS { get; set; }

    public virtual DbSet<AU_RECONSTRUCCIONES> AU_RECONSTRUCCIONES { get; set; }

    public virtual DbSet<AU_RELMAESTROS> AU_RELMAESTROS { get; set; }

    public virtual DbSet<AU_TEMP_TABLE_adminlaboro> AU_TEMP_TABLE_adminlaboro { get; set; }

    public virtual DbSet<AU_TIPOS> AU_TIPOS { get; set; }

    public virtual DbSet<AcumuladoresHistoricos> AcumuladoresHistoricos { get; set; }

    public virtual DbSet<AlertaCategorias> AlertaCategorias { get; set; }

    public virtual DbSet<AlertaConfig> AlertaConfig { get; set; }

    public virtual DbSet<AlertaEstados> AlertaEstados { get; set; }

    public virtual DbSet<AlertaSubTipos> AlertaSubTipos { get; set; }

    public virtual DbSet<AlertaTipos> AlertaTipos { get; set; }

    public virtual DbSet<AlertaTiposEstado> AlertaTiposEstado { get; set; }

    public virtual DbSet<AlertasAgenda> AlertasAgenda { get; set; }

    public virtual DbSet<AlertasAgendaRelacion> AlertasAgendaRelacion { get; set; }

    public virtual DbSet<AlertasEnviadas> AlertasEnviadas { get; set; }

    public virtual DbSet<ArregloLic> ArregloLic { get; set; }

    public virtual DbSet<AtributosAdic> AtributosAdic { get; set; }

    public virtual DbSet<AtributosHistoricos> AtributosHistoricos { get; set; }

    public virtual DbSet<AtributosRegs> AtributosRegs { get; set; }

    public virtual DbSet<AtributosValAdic> AtributosValAdic { get; set; }

    public virtual DbSet<BI_LegajosAtributos> BI_LegajosAtributos { get; set; }

    public virtual DbSet<BI_RH_CapacitacionesAtributos> BI_RH_CapacitacionesAtributos { get; set; }

    public virtual DbSet<BI_RH_ElementosAtributos> BI_RH_ElementosAtributos { get; set; }

    public virtual DbSet<BL2_GANANCIASANEXO2> BL2_GANANCIASANEXO2 { get; set; }

    public virtual DbSet<BL_ACTIVIDADES> BL_ACTIVIDADES { get; set; }

    public virtual DbSet<BL_ACUMLEGAJOSINI> BL_ACUMLEGAJOSINI { get; set; }

    public virtual DbSet<BL_ACUMSASOCIADOS> BL_ACUMSASOCIADOS { get; set; }

    public virtual DbSet<BL_ACUMULADORES> BL_ACUMULADORES { get; set; }

    public virtual DbSet<BL_ALIASTIPOLIQ> BL_ALIASTIPOLIQ { get; set; }

    public virtual DbSet<BL_ANEXO_LIQUIDACIONES> BL_ANEXO_LIQUIDACIONES { get; set; }

    public virtual DbSet<BL_AUDITORIA_ALIAS> BL_AUDITORIA_ALIAS { get; set; }

    public virtual DbSet<BL_AUDITORIA_CAB> BL_AUDITORIA_CAB { get; set; }

    public virtual DbSet<BL_AUDITORIA_CONSULTA> BL_AUDITORIA_CONSULTA { get; set; }

    public virtual DbSet<BL_AUDITORIA_DET> BL_AUDITORIA_DET { get; set; }

    public virtual DbSet<BL_AUDITORIA_MAESTROS> BL_AUDITORIA_MAESTROS { get; set; }

    public virtual DbSet<BL_AUDITORIA_TXT> BL_AUDITORIA_TXT { get; set; }

    public virtual DbSet<BL_AUXNUMEROS> BL_AUXNUMEROS { get; set; }

    public virtual DbSet<BL_AutogestionAccesoDenegado> BL_AutogestionAccesoDenegado { get; set; }

    public virtual DbSet<BL_CONCEPTOS> BL_CONCEPTOS { get; set; }

    public virtual DbSet<BL_CONCEPTOSTIPOLIQ> BL_CONCEPTOSTIPOLIQ { get; set; }

    public virtual DbSet<BL_CONDICIONESLAB> BL_CONDICIONESLAB { get; set; }

    public virtual DbSet<BL_CONVENIOS> BL_CONVENIOS { get; set; }

    public virtual DbSet<BL_CONVENIOSVAC> BL_CONVENIOSVAC { get; set; }

    public virtual DbSet<BL_CONVENIOSVAL> BL_CONVENIOSVAL { get; set; }

    public virtual DbSet<BL_CONVENIOSVAL2> BL_CONVENIOSVAL2 { get; set; }

    public virtual DbSet<BL_DOCSTEXTO> BL_DOCSTEXTO { get; set; }

    public virtual DbSet<BL_EGRESOS_SIMULACION> BL_EGRESOS_SIMULACION { get; set; }

    public virtual DbSet<BL_EMPLEADOSACARGO> BL_EMPLEADOSACARGO { get; set; }

    public virtual DbSet<BL_EMPRESASGRUPOS> BL_EMPRESASGRUPOS { get; set; }

    public virtual DbSet<BL_EMPRESASPERSEVENTUAL> BL_EMPRESASPERSEVENTUAL { get; set; }

    public virtual DbSet<BL_ESCOLARIDADES> BL_ESCOLARIDADES { get; set; }

    public virtual DbSet<BL_ESTADOSCIVILES> BL_ESTADOSCIVILES { get; set; }

    public virtual DbSet<BL_FAMILIARES> BL_FAMILIARES { get; set; }

    public virtual DbSet<BL_FAMILIARESPERIODOSACARGO> BL_FAMILIARESPERIODOSACARGO { get; set; }

    public virtual DbSet<BL_FAMILIARES_INACTIVOS> BL_FAMILIARES_INACTIVOS { get; set; }

    public virtual DbSet<BL_FERIADOS> BL_FERIADOS { get; set; }

    public virtual DbSet<BL_FERIADOS_DETALLE> BL_FERIADOS_DETALLE { get; set; }

    public virtual DbSet<BL_FILTROS_NOVEDADESCONSULTA> BL_FILTROS_NOVEDADESCONSULTA { get; set; }

    public virtual DbSet<BL_FUNCIONESEXTERNAS> BL_FUNCIONESEXTERNAS { get; set; }

    public virtual DbSet<BL_GANANCIAS> BL_GANANCIAS { get; set; }

    public virtual DbSet<BL_GANANCIASANEXO1> BL_GANANCIASANEXO1 { get; set; }

    public virtual DbSet<BL_GANANCIASANEXO2> BL_GANANCIASANEXO2 { get; set; }

    public virtual DbSet<BL_GANANCIASANEXO2_CEDULAR> BL_GANANCIASANEXO2_CEDULAR { get; set; }

    public virtual DbSet<BL_GANANCIASANEXO5> BL_GANANCIASANEXO5 { get; set; }

    public virtual DbSet<BL_GRUPOS> BL_GRUPOS { get; set; }

    public virtual DbSet<BL_GRUPOSDEP> BL_GRUPOSDEP { get; set; }

    public virtual DbSet<BL_GRUPOSVISOR4TA> BL_GRUPOSVISOR4TA { get; set; }

    public virtual DbSet<BL_Ganancias_AnexoIV> BL_Ganancias_AnexoIV { get; set; }

    public virtual DbSet<BL_INCAPACIDADES> BL_INCAPACIDADES { get; set; }

    public virtual DbSet<BL_JOB> BL_JOB { get; set; }

    public virtual DbSet<BL_LEGAJOS> BL_LEGAJOS { get; set; }

    public virtual DbSet<BL_LEGAJOSATRIBUTOS> BL_LEGAJOSATRIBUTOS { get; set; }

    public virtual DbSet<BL_LEGAJOSVACS> BL_LEGAJOSVACS { get; set; }

    public virtual DbSet<BL_LEGAJOSVISTAS> BL_LEGAJOSVISTAS { get; set; }

    public virtual DbSet<BL_LIQEXISTENTES_SIMULACION> BL_LIQEXISTENTES_SIMULACION { get; set; }

    public virtual DbSet<BL_LIQUIDACIONES> BL_LIQUIDACIONES { get; set; }

    public virtual DbSet<BL_LIQUIDACIONESACUMS> BL_LIQUIDACIONESACUMS { get; set; }

    public virtual DbSet<BL_LIQUIDACIONESATRS> BL_LIQUIDACIONESATRS { get; set; }

    public virtual DbSet<BL_LIQUIDACIONESATRS_SIMULACION> BL_LIQUIDACIONESATRS_SIMULACION { get; set; }

    public virtual DbSet<BL_LIQUIDACIONESDET> BL_LIQUIDACIONESDET { get; set; }

    public virtual DbSet<BL_LIQUIDACIONESDET_CENTROAPP> BL_LIQUIDACIONESDET_CENTROAPP { get; set; }

    public virtual DbSet<BL_LIQUIDACIONESDET_CENTROAPP_SIMULACION> BL_LIQUIDACIONESDET_CENTROAPP_SIMULACION { get; set; }

    public virtual DbSet<BL_LIQUIDACIONESDET_SIMULACION> BL_LIQUIDACIONESDET_SIMULACION { get; set; }

    public virtual DbSet<BL_LIQUIDACIONESPAGDEP> BL_LIQUIDACIONESPAGDEP { get; set; }

    public virtual DbSet<BL_LIQUIDACIONESTIPOS> BL_LIQUIDACIONESTIPOS { get; set; }

    public virtual DbSet<BL_LIQUIDACIONESVACS> BL_LIQUIDACIONESVACS { get; set; }

    public virtual DbSet<BL_LIQUIDACIONESVARS> BL_LIQUIDACIONESVARS { get; set; }

    public virtual DbSet<BL_LIQUIDACIONESVARS_SIMULACION> BL_LIQUIDACIONESVARS_SIMULACION { get; set; }

    public virtual DbSet<BL_LIQUIDACIONES_4ta> BL_LIQUIDACIONES_4ta { get; set; }

    public virtual DbSet<BL_LOCKDATOSHISTORICOS> BL_LOCKDATOSHISTORICOS { get; set; }

    public virtual DbSet<BL_LSD_CAB> BL_LSD_CAB { get; set; }

    public virtual DbSet<BL_LSD_DET> BL_LSD_DET { get; set; }

    public virtual DbSet<BL_LUGARESTRABAJO> BL_LUGARESTRABAJO { get; set; }

    public virtual DbSet<BL_LegajosAtributosAdic> BL_LegajosAtributosAdic { get; set; }

    public virtual DbSet<BL_MODCONTRATACIONES> BL_MODCONTRATACIONES { get; set; }

    public virtual DbSet<BL_MONEDAS> BL_MONEDAS { get; set; }

    public virtual DbSet<BL_NACIONALIDADES> BL_NACIONALIDADES { get; set; }

    public virtual DbSet<BL_NOVEDADES> BL_NOVEDADES { get; set; }

    public virtual DbSet<BL_NOVEDADESCONCEPTOS> BL_NOVEDADESCONCEPTOS { get; set; }

    public virtual DbSet<BL_NOVEDADESCONCEPTOS_SUSPENSION> BL_NOVEDADESCONCEPTOS_SUSPENSION { get; set; }

    public virtual DbSet<BL_NOVEDADESDOCUMENTOS> BL_NOVEDADESDOCUMENTOS { get; set; }

    public virtual DbSet<BL_NOVEDADESEVENTUAL> BL_NOVEDADESEVENTUAL { get; set; }

    public virtual DbSet<BL_NOVEDADESGAN> BL_NOVEDADESGAN { get; set; }

    public virtual DbSet<BL_NOVEDADESLEGAJOS> BL_NOVEDADESLEGAJOS { get; set; }

    public virtual DbSet<BL_NOVEDADESLEGAJOS_SUSPENSION> BL_NOVEDADESLEGAJOS_SUSPENSION { get; set; }

    public virtual DbSet<BL_NOVEDADESPERSONALEVENTUAL> BL_NOVEDADESPERSONALEVENTUAL { get; set; }

    public virtual DbSet<BL_NOVEDADESSUSPENDIDAS> BL_NOVEDADESSUSPENDIDAS { get; set; }

    public virtual DbSet<BL_NOVEDADESVARGAN> BL_NOVEDADESVARGAN { get; set; }

    public virtual DbSet<BL_NOVEDADESVARIABLES> BL_NOVEDADESVARIABLES { get; set; }

    public virtual DbSet<BL_NOVEDADES_DATOSAUX> BL_NOVEDADES_DATOSAUX { get; set; }

    public virtual DbSet<BL_NOVEDADES_SUSPENSION> BL_NOVEDADES_SUSPENSION { get; set; }

    public virtual DbSet<BL_NovedadesPedidos> BL_NovedadesPedidos { get; set; }

    public virtual DbSet<BL_NovedadesPedidos_Detalle> BL_NovedadesPedidos_Detalle { get; set; }

    public virtual DbSet<BL_OBJETOSMAESTROS> BL_OBJETOSMAESTROS { get; set; }

    public virtual DbSet<BL_OBJETOSTRANSACCION> BL_OBJETOSTRANSACCION { get; set; }

    public virtual DbSet<BL_PARAMETROS> BL_PARAMETROS { get; set; }

    public virtual DbSet<BL_PARENTESCOS> BL_PARENTESCOS { get; set; }

    public virtual DbSet<BL_PERSONALEVENTUAL> BL_PERSONALEVENTUAL { get; set; }

    public virtual DbSet<BL_PERSONAS> BL_PERSONAS { get; set; }

    public virtual DbSet<BL_PERSONASATRIBUTOS> BL_PERSONASATRIBUTOS { get; set; }

    public virtual DbSet<BL_PROVINCIAS> BL_PROVINCIAS { get; set; }

    public virtual DbSet<BL_RECIBOS> BL_RECIBOS { get; set; }

    public virtual DbSet<BL_RECIBOS_ACCIONESWEB> BL_RECIBOS_ACCIONESWEB { get; set; }

    public virtual DbSet<BL_RECIBOS_AUDITORIAWEB> BL_RECIBOS_AUDITORIAWEB { get; set; }

    public virtual DbSet<BL_RECIBOS_PRORRATEOS> BL_RECIBOS_PRORRATEOS { get; set; }

    public virtual DbSet<BL_RECIBOS_PRORRATEOS_SIMULACION> BL_RECIBOS_PRORRATEOS_SIMULACION { get; set; }

    public virtual DbSet<BL_RECIBOS_SIMULACION> BL_RECIBOS_SIMULACION { get; set; }

    public virtual DbSet<BL_REPARTICIONES> BL_REPARTICIONES { get; set; }

    public virtual DbSet<BL_REPSASOCIADAS> BL_REPSASOCIADAS { get; set; }

    public virtual DbSet<BL_SECURITY_GRUPOS> BL_SECURITY_GRUPOS { get; set; }

    public virtual DbSet<BL_SECURITY_GRUPOSUSUARIOS> BL_SECURITY_GRUPOSUSUARIOS { get; set; }

    public virtual DbSet<BL_SECURITY_PERMISOS> BL_SECURITY_PERMISOS { get; set; }

    public virtual DbSet<BL_SECURITY_SETEO> BL_SECURITY_SETEO { get; set; }

    public virtual DbSet<BL_SECURITY_TIPOS> BL_SECURITY_TIPOS { get; set; }

    public virtual DbSet<BL_SECURITY_USUARIOS> BL_SECURITY_USUARIOS { get; set; }

    public virtual DbSet<BL_SITUACIONESREVISTA> BL_SITUACIONESREVISTA { get; set; }

    public virtual DbSet<BL_SUCESOS> BL_SUCESOS { get; set; }

    public virtual DbSet<BL_SUCESOSCLASES> BL_SUCESOSCLASES { get; set; }

    public virtual DbSet<BL_SUCESOSCLASESTOPES> BL_SUCESOSCLASESTOPES { get; set; }

    public virtual DbSet<BL_SUCESOSDIASHABILES> BL_SUCESOSDIASHABILES { get; set; }

    public virtual DbSet<BL_SUCESOSTOPES> BL_SUCESOSTOPES { get; set; }

    public virtual DbSet<BL_SUCESOSTOPES1> BL_SUCESOSTOPES1 { get; set; }

    public virtual DbSet<BL_SUCESOSTOPES2> BL_SUCESOSTOPES2 { get; set; }

    public virtual DbSet<BL_TAREAS> BL_TAREAS { get; set; }

    public virtual DbSet<BL_TAREASUSU> BL_TAREASUSU { get; set; }

    public virtual DbSet<BL_TEMPVALORESREGISTRADOS> BL_TEMPVALORESREGISTRADOS { get; set; }

    public virtual DbSet<BL_TIPOSEMPLEADORES> BL_TIPOSEMPLEADORES { get; set; }

    public virtual DbSet<BL_TOTALIZADORES> BL_TOTALIZADORES { get; set; }

    public virtual DbSet<BL_USUEMPRESAS> BL_USUEMPRESAS { get; set; }

    public virtual DbSet<BL_VARIABLESDEFINIBLES> BL_VARIABLESDEFINIBLES { get; set; }

    public virtual DbSet<BL_VARIABLESGANANCIAS> BL_VARIABLESGANANCIAS { get; set; }

    public virtual DbSet<BL_VARIABLESPLANILLAGAN> BL_VARIABLESPLANILLAGAN { get; set; }

    public virtual DbSet<BL_VARIABLESPREDEFINIDAS> BL_VARIABLESPREDEFINIDAS { get; set; }

    public virtual DbSet<BL_VARIABLESTOPES> BL_VARIABLESTOPES { get; set; }

    public virtual DbSet<BL_VARIABLESVALS> BL_VARIABLESVALS { get; set; }

    public virtual DbSet<BL_VARIABLESVALS_SIMULACION> BL_VARIABLESVALS_SIMULACION { get; set; }

    public virtual DbSet<BL_VARIABLESVISOR4TA> BL_VARIABLESVISOR4TA { get; set; }

    public virtual DbSet<BL_VARIABLES_F1359> BL_VARIABLES_F1359 { get; set; }

    public virtual DbSet<BL_VARIABLES_F2122> BL_VARIABLES_F2122 { get; set; }

    public virtual DbSet<BL_VISTAS> BL_VISTAS { get; set; }

    public virtual DbSet<BL_ZONAS> BL_ZONAS { get; set; }

    public virtual DbSet<BRCOLEXCLUIDAS> BRCOLEXCLUIDAS { get; set; }

    public virtual DbSet<BRCONFIG> BRCONFIG { get; set; }

    public virtual DbSet<BRCONFIGDET> BRCONFIGDET { get; set; }

    public virtual DbSet<BRTABLAS> BRTABLAS { get; set; }

    public virtual DbSet<BRTABLASCOLS> BRTABLASCOLS { get; set; }

    public virtual DbSet<BRTABLASCOLSCASE> BRTABLASCOLSCASE { get; set; }

    public virtual DbSet<BRTABLASJOINS> BRTABLASJOINS { get; set; }

    public virtual DbSet<Bl_AutogestionCambiosPer> Bl_AutogestionCambiosPer { get; set; }

    public virtual DbSet<Bl_AutogestionCambiosPerPendientes> Bl_AutogestionCambiosPerPendientes { get; set; }

    public virtual DbSet<CATEGORIAS> CATEGORIAS { get; set; }

    public virtual DbSet<CENTROSAP> CENTROSAP { get; set; }

    public virtual DbSet<CONTROLESEXP> CONTROLESEXP { get; set; }

    public virtual DbSet<CUENTAS> CUENTAS { get; set; }

    public virtual DbSet<CentrosAppSync> CentrosAppSync { get; set; }

    public virtual DbSet<Consulta1Variables4ta> Consulta1Variables4ta { get; set; }

    public virtual DbSet<Consulta2Variables4ta> Consulta2Variables4ta { get; set; }

    public virtual DbSet<ConsultaVariables4ta_Mes> ConsultaVariables4ta_Mes { get; set; }

    public virtual DbSet<CuentasSync> CuentasSync { get; set; }

    public virtual DbSet<EMPRESAS> EMPRESAS { get; set; }

    public virtual DbSet<EmpresasBASCS> EmpresasBASCS { get; set; }

    public virtual DbSet<EmpresasRelacion> EmpresasRelacion { get; set; }

    public virtual DbSet<Evidencias> Evidencias { get; set; }

    public virtual DbSet<FX_ScriptExec> FX_ScriptExec { get; set; }

    public virtual DbSet<FX_ScriptTransactions> FX_ScriptTransactions { get; set; }

    public virtual DbSet<FX_SysVersion> FX_SysVersion { get; set; }

    public virtual DbSet<FmtControles> FmtControles { get; set; }

    public virtual DbSet<FmtControlesAlias> FmtControlesAlias { get; set; }

    public virtual DbSet<FmtControlesExp> FmtControlesExp { get; set; }

    public virtual DbSet<FmtControlesSel> FmtControlesSel { get; set; }

    public virtual DbSet<FmtJoinsExp> FmtJoinsExp { get; set; }

    public virtual DbSet<FmtLineas> FmtLineas { get; set; }

    public virtual DbSet<FmtLineasExp> FmtLineasExp { get; set; }

    public virtual DbSet<FmtTiposExp> FmtTiposExp { get; set; }

    public virtual DbSet<Formatos> Formatos { get; set; }

    public virtual DbSet<FormatosExp> FormatosExp { get; set; }

    public virtual DbSet<GETATRIBUTOS> GETATRIBUTOS { get; set; }

    public virtual DbSet<LegajosPermitidosAgenda> LegajosPermitidosAgenda { get; set; }

    public virtual DbSet<MODELIN> MODELIN { get; set; }

    public virtual DbSet<MODELOS> MODELOS { get; set; }

    public virtual DbSet<MyTable> MyTable { get; set; }

    public virtual DbSet<NOVEDADES_NORMALIZADAS> NOVEDADES_NORMALIZADAS { get; set; }

    public virtual DbSet<NOVEDADES_NORMALIZADAS2> NOVEDADES_NORMALIZADAS2 { get; set; }

    public virtual DbSet<NOVEDADES_NORMALIZADAS3> NOVEDADES_NORMALIZADAS3 { get; set; }

    public virtual DbSet<NUMEROS> NUMEROS { get; set; }

    public virtual DbSet<NovedadesLegajos> NovedadesLegajos { get; set; }

    public virtual DbSet<ORG_CarpetaCarpeta> ORG_CarpetaCarpeta { get; set; }

    public virtual DbSet<ORG_CarpetaPersona> ORG_CarpetaPersona { get; set; }

    public virtual DbSet<ORG_CarpetaPuesto> ORG_CarpetaPuesto { get; set; }

    public virtual DbSet<ORG_Carpetas> ORG_Carpetas { get; set; }

    public virtual DbSet<ORG_Estructuras> ORG_Estructuras { get; set; }

    public virtual DbSet<ORG_Principal> ORG_Principal { get; set; }

    public virtual DbSet<ORG_PuestoPersona> ORG_PuestoPersona { get; set; }

    public virtual DbSet<ORG_PuestoPuesto> ORG_PuestoPuesto { get; set; }

    public virtual DbSet<ORG_Puestos> ORG_Puestos { get; set; }

    public virtual DbSet<PARAMETROS> PARAMETROS { get; set; }

    public virtual DbSet<PERMISOS> PERMISOS { get; set; }

    public virtual DbSet<PERMISOSABM> PERMISOSABM { get; set; }

    public virtual DbSet<PERMISOSCAMPOS> PERMISOSCAMPOS { get; set; }

    public virtual DbSet<PROGRAMAS> PROGRAMAS { get; set; }

    public virtual DbSet<PROGRAMAS_IMPORTACION> PROGRAMAS_IMPORTACION { get; set; }

    public virtual DbSet<PersonasPermitidasAgenda> PersonasPermitidasAgenda { get; set; }

    public virtual DbSet<ProvinciasSync> ProvinciasSync { get; set; }

    public virtual DbSet<Prueba> Prueba { get; set; }

    public virtual DbSet<RHV_Cancelaciones> RHV_Cancelaciones { get; set; }

    public virtual DbSet<RHV_CapacitacionesDePlan> RHV_CapacitacionesDePlan { get; set; }

    public virtual DbSet<RHV_CapacitacionesProveedores> RHV_CapacitacionesProveedores { get; set; }

    public virtual DbSet<RHV_EvaluacionesDePlan> RHV_EvaluacionesDePlan { get; set; }

    public virtual DbSet<RHV_Evidencias> RHV_Evidencias { get; set; }

    public virtual DbSet<RHV_EvidenciasHabilidades> RHV_EvidenciasHabilidades { get; set; }

    public virtual DbSet<RHV_EvidenciasHabilidadesAdHoc> RHV_EvidenciasHabilidadesAdHoc { get; set; }

    public virtual DbSet<RHV_Planes> RHV_Planes { get; set; }

    public virtual DbSet<RHV_PlanesPersonas> RHV_PlanesPersonas { get; set; }

    public virtual DbSet<RHV_VistaEvidencias> RHV_VistaEvidencias { get; set; }

    public virtual DbSet<RHV_Vista_EvidenciasFaltantes_Documentos> RHV_Vista_EvidenciasFaltantes_Documentos { get; set; }

    public virtual DbSet<RHV_Vista_EvidenciasFaltantes_Evaluaciones> RHV_Vista_EvidenciasFaltantes_Evaluaciones { get; set; }

    public virtual DbSet<RH_AlternativasCapacitaciones> RH_AlternativasCapacitaciones { get; set; }

    public virtual DbSet<RH_AlternativasDocumentos> RH_AlternativasDocumentos { get; set; }

    public virtual DbSet<RH_AlternativasEvaluaciones> RH_AlternativasEvaluaciones { get; set; }

    public virtual DbSet<RH_Capacitaciones> RH_Capacitaciones { get; set; }

    public virtual DbSet<RH_CapacitacionesAtributos> RH_CapacitacionesAtributos { get; set; }

    public virtual DbSet<RH_CapacitacionesEvaluaciones> RH_CapacitacionesEvaluaciones { get; set; }

    public virtual DbSet<RH_CapacitacionesProveedores> RH_CapacitacionesProveedores { get; set; }

    public virtual DbSet<RH_Documentos> RH_Documentos { get; set; }

    public virtual DbSet<RH_ElementosAtributos> RH_ElementosAtributos { get; set; }

    public virtual DbSet<RH_ElementosCapacitaciones> RH_ElementosCapacitaciones { get; set; }

    public virtual DbSet<RH_ElementosDeTrabajo> RH_ElementosDeTrabajo { get; set; }

    public virtual DbSet<RH_ElementosMeses> RH_ElementosMeses { get; set; }

    public virtual DbSet<RH_ElementosPuestos> RH_ElementosPuestos { get; set; }

    public virtual DbSet<RH_Escalas> RH_Escalas { get; set; }

    public virtual DbSet<RH_Escalas_Valores> RH_Escalas_Valores { get; set; }

    public virtual DbSet<RH_EsquemasDePlanes> RH_EsquemasDePlanes { get; set; }

    public virtual DbSet<RH_EstadosDeCapacitacion> RH_EstadosDeCapacitacion { get; set; }

    public virtual DbSet<RH_Evaluaciones> RH_Evaluaciones { get; set; }

    public virtual DbSet<RH_EvaluacionesFormularios> RH_EvaluacionesFormularios { get; set; }

    public virtual DbSet<RH_Factores> RH_Factores { get; set; }

    public virtual DbSet<RH_Formularios> RH_Formularios { get; set; }

    public virtual DbSet<RH_FormulariosFactores> RH_FormulariosFactores { get; set; }

    public virtual DbSet<RH_Formularios_Detalle> RH_Formularios_Detalle { get; set; }

    public virtual DbSet<RH_Habilidades> RH_Habilidades { get; set; }

    public virtual DbSet<RH_HabilidadesAdHoc> RH_HabilidadesAdHoc { get; set; }

    public virtual DbSet<RH_HabilidadesAlternativas> RH_HabilidadesAlternativas { get; set; }

    public virtual DbSet<RH_Novedades> RH_Novedades { get; set; }

    public virtual DbSet<RH_NovedadesCancelaciones> RH_NovedadesCancelaciones { get; set; }

    public virtual DbSet<RH_NovedadesCancelaciones_Anexo> RH_NovedadesCancelaciones_Anexo { get; set; }

    public virtual DbSet<RH_NovedadesCapacitaciones> RH_NovedadesCapacitaciones { get; set; }

    public virtual DbSet<RH_NovedadesDocumentos> RH_NovedadesDocumentos { get; set; }

    public virtual DbSet<RH_NovedadesElementos> RH_NovedadesElementos { get; set; }

    public virtual DbSet<RH_NovedadesEvaluaciones> RH_NovedadesEvaluaciones { get; set; }

    public virtual DbSet<RH_NovedadesEvaluaciones_AnexoFactores> RH_NovedadesEvaluaciones_AnexoFactores { get; set; }

    public virtual DbSet<RH_NovedadesExcepciones> RH_NovedadesExcepciones { get; set; }

    public virtual DbSet<RH_NovedadesHabilidades> RH_NovedadesHabilidades { get; set; }

    public virtual DbSet<RH_NovedadesPersonas> RH_NovedadesPersonas { get; set; }

    public virtual DbSet<RH_NovedadesPuestos> RH_NovedadesPuestos { get; set; }

    public virtual DbSet<RH_NovedadesTipos> RH_NovedadesTipos { get; set; }

    public virtual DbSet<RH_Personas> RH_Personas { get; set; }

    public virtual DbSet<RH_Personas2> RH_Personas2 { get; set; }

    public virtual DbSet<RH_PlanesCapacitaciones> RH_PlanesCapacitaciones { get; set; }

    public virtual DbSet<RH_PlanesDeCapacitacion> RH_PlanesDeCapacitacion { get; set; }

    public virtual DbSet<RH_PlanesDeEvaluacion> RH_PlanesDeEvaluacion { get; set; }

    public virtual DbSet<RH_PlanesEvaluaciones> RH_PlanesEvaluaciones { get; set; }

    public virtual DbSet<RH_PlanesFormularios> RH_PlanesFormularios { get; set; }

    public virtual DbSet<RH_PlanesProveedores> RH_PlanesProveedores { get; set; }

    public virtual DbSet<RH_PlanesResponsables> RH_PlanesResponsables { get; set; }

    public virtual DbSet<RH_Proveedores> RH_Proveedores { get; set; }

    public virtual DbSet<RH_Puestos> RH_Puestos { get; set; }

    public virtual DbSet<RH_PuestosHabilidades> RH_PuestosHabilidades { get; set; }

    public virtual DbSet<RH_PuestosHistorico> RH_PuestosHistorico { get; set; }

    public virtual DbSet<RTF_Textos> RTF_Textos { get; set; }

    public virtual DbSet<SIRADIG_FamiliarGastoEducacion> SIRADIG_FamiliarGastoEducacion { get; set; }

    public virtual DbSet<SIRADIG_Parentescos> SIRADIG_Parentescos { get; set; }

    public virtual DbSet<SIRADIG_ParentescosRelacion> SIRADIG_ParentescosRelacion { get; set; }

    public virtual DbSet<SIRADIG_Secuencia> SIRADIG_Secuencia { get; set; }

    public virtual DbSet<SIRADIG_Variables> SIRADIG_Variables { get; set; }

    public virtual DbSet<TABLAS> TABLAS { get; set; }

    public virtual DbSet<TIPODOC> TIPODOC { get; set; }

    public virtual DbSet<TableConstraint> TableConstraint { get; set; }

    public virtual DbSet<Talonarios> Talonarios { get; set; }

    public virtual DbSet<TipoDocSync> TipoDocSync { get; set; }

    public virtual DbSet<USUARIOS> USUARIOS { get; set; }

    public virtual DbSet<USUEMPRESAS> USUEMPRESAS { get; set; }

    public virtual DbSet<UsuariosYGrupos> UsuariosYGrupos { get; set; }

    public virtual DbSet<VIEW_LiqAppFaltantes> VIEW_LiqAppFaltantes { get; set; }

    public virtual DbSet<VISTAATRIBUTOSEMP> VISTAATRIBUTOSEMP { get; set; }

    public virtual DbSet<VISTAVARIABLES> VISTAVARIABLES { get; set; }

    public virtual DbSet<ValoresEspeciales> ValoresEspeciales { get; set; }

    public virtual DbSet<VarAcumVisor4ta> VarAcumVisor4ta { get; set; }

    public virtual DbSet<VarSiradig> VarSiradig { get; set; }

    public virtual DbSet<VariablesDeAuditoria> VariablesDeAuditoria { get; set; }

    public virtual DbSet<VariablesHistoricas> VariablesHistoricas { get; set; }

    public virtual DbSet<vAGENDA_ALERTA> vAGENDA_ALERTA { get; set; }

    public virtual DbSet<vAGENDA_ALERTA_1> vAGENDA_ALERTA_1 { get; set; }

    public virtual DbSet<vAGENDA_ALERTA_10> vAGENDA_ALERTA_10 { get; set; }

    public virtual DbSet<vAGENDA_ALERTA_11> vAGENDA_ALERTA_11 { get; set; }

    public virtual DbSet<vAGENDA_ALERTA_12> vAGENDA_ALERTA_12 { get; set; }

    public virtual DbSet<vAGENDA_ALERTA_2> vAGENDA_ALERTA_2 { get; set; }

    public virtual DbSet<vAGENDA_ALERTA_3> vAGENDA_ALERTA_3 { get; set; }

    public virtual DbSet<vAGENDA_ALERTA_4> vAGENDA_ALERTA_4 { get; set; }

    public virtual DbSet<vAGENDA_ALERTA_5> vAGENDA_ALERTA_5 { get; set; }

    public virtual DbSet<vAGENDA_ALERTA_6> vAGENDA_ALERTA_6 { get; set; }

    public virtual DbSet<vAGENDA_ALERTA_7> vAGENDA_ALERTA_7 { get; set; }

    public virtual DbSet<vAGENDA_ALERTA_8> vAGENDA_ALERTA_8 { get; set; }

    public virtual DbSet<vAGENDA_ALERTA_9> vAGENDA_ALERTA_9 { get; set; }

    public virtual DbSet<vAUDI_ACUMULADORES> vAUDI_ACUMULADORES { get; set; }

    public virtual DbSet<vAUDI_ACUMULADORES_DET1> vAUDI_ACUMULADORES_DET1 { get; set; }

    public virtual DbSet<vAUDI_CONCEPTOS> vAUDI_CONCEPTOS { get; set; }

    public virtual DbSet<vAUDI_CONCEPTOS_DET1> vAUDI_CONCEPTOS_DET1 { get; set; }

    public virtual DbSet<vAUDI_CONCEPTOS_DET2> vAUDI_CONCEPTOS_DET2 { get; set; }

    public virtual DbSet<vAUDI_FAMILIARES> vAUDI_FAMILIARES { get; set; }

    public virtual DbSet<vAUDI_FAMILIARES_DET1> vAUDI_FAMILIARES_DET1 { get; set; }

    public virtual DbSet<vAUDI_LEGAJOS> vAUDI_LEGAJOS { get; set; }

    public virtual DbSet<vAUDI_LEGAJOS_DET1> vAUDI_LEGAJOS_DET1 { get; set; }

    public virtual DbSet<vAUDI_LEGAJOS_DET2> vAUDI_LEGAJOS_DET2 { get; set; }

    public virtual DbSet<vAUDI_NOVGANANCIAS> vAUDI_NOVGANANCIAS { get; set; }

    public virtual DbSet<vAUDI_NOVGANANCIAS_DET> vAUDI_NOVGANANCIAS_DET { get; set; }

    public virtual DbSet<vAUDI_PERSONAS> vAUDI_PERSONAS { get; set; }

    public virtual DbSet<vAUDI_PERSONAS_DET1> vAUDI_PERSONAS_DET1 { get; set; }

    public virtual DbSet<vAUDI_VARIABLES> vAUDI_VARIABLES { get; set; }

    public virtual DbSet<vAUDI_VARIABLES_DET1> vAUDI_VARIABLES_DET1 { get; set; }

    public virtual DbSet<vAtributosLeg> vAtributosLeg { get; set; }

    public virtual DbSet<vAudiLiq> vAudiLiq { get; set; }

    public virtual DbSet<vAuditoriaCampos> vAuditoriaCampos { get; set; }

    public virtual DbSet<vAuditoriaMaestros> vAuditoriaMaestros { get; set; }

    public virtual DbSet<vAutogestion_CtaBancaria> vAutogestion_CtaBancaria { get; set; }

    public virtual DbSet<vAutogestion_Familiares> vAutogestion_Familiares { get; set; }

    public virtual DbSet<vAutogestion_Familiares2> vAutogestion_Familiares2 { get; set; }

    public virtual DbSet<vAutogestion_Legajos> vAutogestion_Legajos { get; set; }

    public virtual DbSet<vAutogestion_Legajos2> vAutogestion_Legajos2 { get; set; }

    public virtual DbSet<vAutogestion_LoguinsIni> vAutogestion_LoguinsIni { get; set; }

    public virtual DbSet<vAutogestion_ManagersYEmpleados> vAutogestion_ManagersYEmpleados { get; set; }

    public virtual DbSet<vAutogestion_Personas> vAutogestion_Personas { get; set; }

    public virtual DbSet<vAutogestion_Personas2> vAutogestion_Personas2 { get; set; }

    public virtual DbSet<vAutogestion_Puestos> vAutogestion_Puestos { get; set; }

    public virtual DbSet<vAutogestion_Recibos> vAutogestion_Recibos { get; set; }

    public virtual DbSet<vAutogestion_RecibosDetalle> vAutogestion_RecibosDetalle { get; set; }

    public virtual DbSet<vBl_Legajos> vBl_Legajos { get; set; }

    public virtual DbSet<vCtaBancaria> vCtaBancaria { get; set; }

    public virtual DbSet<vDiasLiquidadosAnual> vDiasLiquidadosAnual { get; set; }

    public virtual DbSet<vDiasLiquidadosMensual> vDiasLiquidadosMensual { get; set; }

    public virtual DbSet<vDiasLiquidadosNovedad> vDiasLiquidadosNovedad { get; set; }

    public virtual DbSet<vHabilidadesAlternativas> vHabilidadesAlternativas { get; set; }

    public virtual DbSet<vHabilidadesLegajos> vHabilidadesLegajos { get; set; }

    public virtual DbSet<vHabilidadesPuestos> vHabilidadesPuestos { get; set; }

    public virtual DbSet<vLegajosCBU> vLegajosCBU { get; set; }

    public virtual DbSet<vLegajosLiquidados> vLegajosLiquidados { get; set; }

    public virtual DbSet<vLegajosOrganigrama> vLegajosOrganigrama { get; set; }

    public virtual DbSet<vOrdenLiquidaciones> vOrdenLiquidaciones { get; set; }

    public virtual DbSet<vOrdenNovedades> vOrdenNovedades { get; set; }

    public virtual DbSet<vOrgPuestosLegajos> vOrgPuestosLegajos { get; set; }

    public virtual DbSet<vOrganigrama> vOrganigrama { get; set; }

    public virtual DbSet<vPBI_Categorias> vPBI_Categorias { get; set; }

    public virtual DbSet<vPBI_CentrosA> vPBI_CentrosA { get; set; }

    public virtual DbSet<vPBI_CentrosB> vPBI_CentrosB { get; set; }

    public virtual DbSet<vPBI_Convenios> vPBI_Convenios { get; set; }

    public virtual DbSet<vPBI_Legajos> vPBI_Legajos { get; set; }

    public virtual DbSet<vPBI_LugaresDeTrabajo> vPBI_LugaresDeTrabajo { get; set; }

    public virtual DbSet<vPBI_ModContrataciones> vPBI_ModContrataciones { get; set; }

    public virtual DbSet<vPBI_Personas> vPBI_Personas { get; set; }

    public virtual DbSet<vPBI_Recibos> vPBI_Recibos { get; set; }

    public virtual DbSet<vPBI_RecibosDetalle> vPBI_RecibosDetalle { get; set; }

    public virtual DbSet<vPBI_Reparticiones> vPBI_Reparticiones { get; set; }

    public virtual DbSet<vPBI_TotalNeto> vPBI_TotalNeto { get; set; }

    public virtual DbSet<vPuestosEmpresas> vPuestosEmpresas { get; set; }

    public virtual DbSet<vRegistroVacAnuales> vRegistroVacAnuales { get; set; }

    public virtual DbSet<vReparticionesLegajos> vReparticionesLegajos { get; set; }

    public virtual DbSet<vReparticionesLegajos2> vReparticionesLegajos2 { get; set; }

    public virtual DbSet<vResponsablesCapacitaciones> vResponsablesCapacitaciones { get; set; }

    public virtual DbSet<vTodasLasPersonas> vTodasLasPersonas { get; set; }

    public virtual DbSet<vTodasLasVariables> vTodasLasVariables { get; set; }

    public virtual DbSet<vTodosLosAcumuladores> vTodosLosAcumuladores { get; set; }

    public virtual DbSet<vTodosLosConceptos> vTodosLosConceptos { get; set; }

    public virtual DbSet<vTodosLosLegajos> vTodosLosLegajos { get; set; }

    public virtual DbSet<vVariablesDeNovedades> vVariablesDeNovedades { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=servidorblb\\sql2019;Initial Catalog=400_BASSINDATOS_DESPUES;User ID=sa;Password=sa;Encrypt=False;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ASYNC_FECHAREG>(entity =>
        {
            entity.HasKey(e => new { e.IdProceso, e.IdLegajo, e.Id }).HasFillFactor(90);

            entity.Property(e => e.FechaReg).HasColumnType("datetime");

            entity.HasOne(d => d.IdProcesoNavigation).WithMany(p => p.ASYNC_FECHAREG)
                .HasForeignKey(d => d.IdProceso)
                .HasConstraintName("FK_ASYNC_FECHAREG_ASYNC_PROCESOS");
        });

        modelBuilder.Entity<ASYNC_FECHAREG_SUSPENSION>(entity =>
        {
            entity.HasKey(e => new { e.IdProceso, e.IdLegajo, e.Id }).HasFillFactor(90);

            entity.Property(e => e.FechaReg).HasColumnType("datetime");

            entity.HasOne(d => d.IdProcesoNavigation).WithMany(p => p.ASYNC_FECHAREG_SUSPENSION)
                .HasForeignKey(d => d.IdProceso)
                .HasConstraintName("FK_ASYNC_FECHAREG_SUSPENSION_ASYNC_PROCESOS");
        });

        modelBuilder.Entity<ASYNC_NOVEDADES>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.IdProceso, e.IdLiquidacion, e.IdLegajo }, "IX_ASYNC_NOVEDADES").HasFillFactor(90);

            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodVariable)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ConceptoDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExprFormula).HasColumnType("text");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoProrrateoPeriodos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VarEnRec)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdProcesoNavigation).WithMany(p => p.ASYNC_NOVEDADES)
                .HasForeignKey(d => d.IdProceso)
                .HasConstraintName("FK_ASYNC_NOVEDADES_ASYNC_PROCESOS");
        });

        modelBuilder.Entity<ASYNC_PROCESOS>(entity =>
        {
            entity.HasKey(e => e.IdProceso).HasFillFactor(90);

            entity.Property(e => e.ComputerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaHora)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ASYNC_VARIABLES>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.IdProceso, e.IdLiquidacion, e.IdLegajo }, "IX_ASYNC_VARIABLES").HasFillFactor(90);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Valor).HasColumnType("decimal(38, 5)");

            entity.HasOne(d => d.IdProcesoNavigation).WithMany(p => p.ASYNC_VARIABLES)
                .HasForeignKey(d => d.IdProceso)
                .HasConstraintName("FK_ASYNC_VARIABLES_ASYNC_PROCESOS");
        });

        modelBuilder.Entity<ATRIBUTOS>(entity =>
        {
            entity.HasKey(e => e.CODATR).HasFillFactor(90);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("BI_Atributos_INS_UPD_DEL");
                    tb.HasTrigger("CTRL_CODATR");
                });

            entity.Property(e => e.CODATR)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PREFIATR)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ATRIBUTOSEMP>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb =>
                {
                    tb.HasTrigger("CTRL_CODEMP");
                    tb.HasTrigger("CTRL_CODEMP_DELETE");
                    tb.HasTrigger("CTRL_CODEMP_UPDATE");
                });

            entity.Property(e => e.CODATR)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.CODATRNavigation).WithMany()
                .HasForeignKey(d => d.CODATR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ATRIBUTOSEMP_ATRIBUTOS");

            entity.HasOne(d => d.CODEMPNavigation).WithMany()
                .HasForeignKey(d => d.CODEMP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ATRIBUTOSEMP_EMPRESAS");
        });

        modelBuilder.Entity<ATRIBUTOSVAL>(entity =>
        {
            entity.HasKey(e => new { e.CODATR, e.CODATRVAL }).HasFillFactor(90);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("CTRL_CODATRVAL");
                    tb.HasTrigger("CTRL_CODATRVAL_DELETE");
                    tb.HasTrigger("CTRL_CODATRVAL_UPDATE");
                });

            entity.Property(e => e.CODATR)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CODATRVAL)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DEFECTO).HasDefaultValue((byte)1);
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.CODATRNavigation).WithMany(p => p.ATRIBUTOSVAL)
                .HasForeignKey(d => d.CODATR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ATRIBUTOSVAL_ATRIBUTOS");
        });

        modelBuilder.Entity<AUX_ASIENTOS>(entity =>
        {
            entity.HasKey(e => new { e.IdTalonario, e.MesLiq, e.CodEmp, e.IdLiquidacion });

            entity.Property(e => e.MesLiq).HasColumnType("datetime");
            entity.Property(e => e.DescripLiq)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaEval).HasColumnType("datetime");
        });

        modelBuilder.Entity<AUX_LINASIENTOS>(entity =>
        {
            entity.HasKey(e => e.Secuencia);

            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Debe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Haber).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<AUX_NOTIFICACION>(entity =>
        {
            entity.HasKey(e => new { e.IdOcurrencia, e.LEGAJO })
                .HasName("PK_AUXNOTIFICACION")
                .HasFillFactor(90);

            entity.Property(e => e.LEGAJO)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CODSUCESO)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentario)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FecNotifJustif).HasColumnType("datetime");
            entity.Property(e => e.FecPrevNot).HasColumnType("datetime");
            entity.Property(e => e.NOMBRE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Orden).ValueGeneratedOnAdd();
            entity.Property(e => e.TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<AU_CAMPOS>(entity =>
        {
            entity.HasKey(e => new { e.IdAud, e.IdCampo })
                .HasName("PK_AU_DATOS")
                .HasFillFactor(90);

            entity.Property(e => e.Campo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CampoCod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodObjeto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ObjetoBase)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AU_CODIGOSFORMATOS>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodFormato)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Masters)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AU_CONFIG>(entity =>
        {
            entity.HasKey(e => new { e.IdAud, e.CodObjeto }).HasFillFactor(90);

            entity.Property(e => e.CodObjeto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Alias)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CampoLogico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CamposAMostrar)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DesdeAct).HasColumnType("smalldatetime");
            entity.Property(e => e.FieldRelacional)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HastaAct).HasColumnType("smalldatetime");
            entity.Property(e => e.JoinsACompletar)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ObjRelacional)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AU_DATOS>(entity =>
        {
            entity.HasKey(e => e.IdDato)
                .HasName("PK_AU_DATOS_1")
                .HasFillFactor(90);

            entity.Property(e => e.IdDato).ValueGeneratedNever();
            entity.Property(e => e.CodCampoLogico)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CodObjeto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NuevoValor).HasColumnType("text");
            entity.Property(e => e.Valor).HasColumnType("text");
        });

        modelBuilder.Entity<AU_MOVIMIENTOS>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodObjeto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.NombreMaquina)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AU_RECONSTRUCCIONES>(entity =>
        {
            entity.HasKey(e => e.IdRec).HasFillFactor(90);

            entity.Property(e => e.IdRec).ValueGeneratedNever();
            entity.Property(e => e.RecCodFormato)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RecFecha).HasColumnType("smalldatetime");
            entity.Property(e => e.RecFechaGen).HasColumnType("smalldatetime");
            entity.Property(e => e.RecObservacion)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AU_RELMAESTROS>(entity =>
        {
            entity.HasKey(e => e.Maestro).HasFillFactor(90);

            entity.Property(e => e.Maestro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JoinParaHistoria)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.SelectParaHistoria)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.TablaId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AU_TEMP_TABLE_adminlaboro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AU_TEMP_TABLE_adminlaboro", "adminlaboro");

            entity.Property(e => e.CampoCod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodCampoLogico)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CodObjeto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Legajo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.NombreMaquina)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NuevoValor)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.ObjetoBase)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.campo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.fecha).HasColumnType("datetime");
            entity.Property(e => e.usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AU_TIPOS>(entity =>
        {
            entity.HasKey(e => e.IdTipo).HasFillFactor(90);

            entity.Property(e => e.IdTipo).ValueGeneratedNever();
            entity.Property(e => e.CodTipo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Formato)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AcumuladoresHistoricos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AcumuladoresHistoricos");

            entity.Property(e => e.MesLiq).HasColumnType("smalldatetime");
            entity.Property(e => e.Valor).HasColumnType("decimal(38, 5)");
        });

        modelBuilder.Entity<AlertaCategorias>(entity =>
        {
            entity.HasKey(e => e.IdCategoria);

            entity.Property(e => e.IdCategoria).ValueGeneratedNever();
            entity.Property(e => e.CategoriaNombre)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AlertaConfig>(entity =>
        {
            entity.HasKey(e => e.IdAlerta);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GrupoDeAnalisis).IsUnicode(false);
            entity.Property(e => e.Mensaje_Asunto).IsUnicode(false);
            entity.Property(e => e.Mensaje_CC).IsUnicode(false);
            entity.Property(e => e.Mensaje_CCTexto).IsUnicode(false);
            entity.Property(e => e.Mensaje_De).IsUnicode(false);
            entity.Property(e => e.Mensaje_Para).IsUnicode(false);
            entity.Property(e => e.Mensaje_ParaTexto).IsUnicode(false);
            entity.Property(e => e.Mensaje_Texto).IsUnicode(false);
        });

        modelBuilder.Entity<AlertaEstados>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DescError)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.MaquinaPedido)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MaquinaServicio)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TipoAlerta)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UltimaFecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<AlertaSubTipos>(entity =>
        {
            entity.HasKey(e => e.IdSubTipoAlerta);

            entity.Property(e => e.IdSubTipoAlerta).ValueGeneratedNever();
            entity.Property(e => e.SubTipoNombre)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AlertaTipos>(entity =>
        {
            entity.HasKey(e => e.IdTipoAlerta).HasName("PK_AlertaTipo");

            entity.Property(e => e.IdTipoAlerta).ValueGeneratedNever();
            entity.Property(e => e.TipoNombre)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AlertaTiposEstado>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AlertasAgenda>(entity =>
        {
            entity.HasKey(e => e.IdAlertaAgenda);

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.TipoFecha)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSubTipoAlertaNavigation).WithMany(p => p.AlertasAgenda)
                .HasForeignKey(d => d.IdSubTipoAlerta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertasAgenda_AlertasSubTipos");
        });

        modelBuilder.Entity<AlertasAgendaRelacion>(entity =>
        {
            entity.HasKey(e => e.IdAlertaAgenda);

            entity.Property(e => e.IdAlertaAgenda).ValueGeneratedNever();
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAlertaAgendaNavigation).WithOne(p => p.AlertasAgendaRelacion)
                .HasForeignKey<AlertasAgendaRelacion>(d => d.IdAlertaAgenda)
                .HasConstraintName("FK_AlertasAgendaRelacion_AlertasAgenda");
        });

        modelBuilder.Entity<AlertasEnviadas>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FechaEnvio).HasColumnType("datetime");
        });

        modelBuilder.Entity<ArregloLic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ArregloLic");

            entity.Property(e => e.Valor).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<AtributosAdic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AtributosAdic");

            entity.Property(e => e.CODATR)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PREFIATR)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AtributosHistoricos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AtributosHistoricos");

            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MesLiq).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<AtributosRegs>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AtributosRegs");

            entity.Property(e => e.CodAtr1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtr2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtr3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtr4)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtr5)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtrVal1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtrVal2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtrVal3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtrVal4)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtrVal5)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<AtributosValAdic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AtributosValAdic");

            entity.Property(e => e.CODATR)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CODATRVAL)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BI_LegajosAtributos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BI_LegajosAtributos");

            entity.Property(e => e.AAA_Trabajados_Asoc__Arg__De_Actores)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AAA Trabajados Asoc. Arg. De Actores");
            entity.Property(e => e.APL_Actividad_Prom_LEC)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("APL Actividad Prom LEC");
            entity.Property(e => e.APR_Act_Prom_LPS)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("APR Act.Prom.LPS");
            entity.Property(e => e.BLS_Es_beneficiario_Ley_27_549_27_718)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BLS Es beneficiario Ley 27.549/27.718");
            entity.Property(e => e.C40_Es_trabajador_convenio_40_1989)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("C40 Es trabajador convenio 40/1989");
            entity.Property(e => e.CAT_Categoria_p_recibos)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CAT Categoria p/recibos");
            entity.Property(e => e.CA_Cargos_p__recibos)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CA Cargos p/ recibos");
            entity.Property(e => e.CED_Impuesto_Cedular)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CED Impuesto Cedular");
            entity.Property(e => e.CLE_Costo_Sal__BASHORAS)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CLE Costo Sal. BASHORAS");
            entity.Property(e => e.CON_Convenio)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CON Convenio");
            entity.Property(e => e.CSA_LPS__no_vigente_)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CSA LPS *no vigente*");
            entity.Property(e => e.CTR_Centro_de_Aprop_)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CTR Centro de Aprop.");
            entity.Property(e => e.DPT_Descripción__Puesto)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DPT Descripción  Puesto");
            entity.Property(e => e.EGC_Encuesta_Gob_Ciudad)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EGC Encuesta Gob Ciudad");
            entity.Property(e => e.FP2_Fecha_de_pago_esp)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FP2 Fecha de pago esp");
            entity.Property(e => e.FP_Fecha_de_pago)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FP Fecha de pago");
            entity.Property(e => e.GEN_General)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GEN General");
            entity.Property(e => e.GER_Gerentes_Resp_cons)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GER Gerentes Resp cons");
            entity.Property(e => e.HOR_HORAS_efectivas__LPS)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HOR HORAS efectivas: LPS");
            entity.Property(e => e.IdLegajo)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.LEY_Leyenda_en_recibo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEY Leyenda en recibo");
            entity.Property(e => e.NA1_Nivel_Académico_comp)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NA1 Nivel Académico comp");
            entity.Property(e => e.NA_Nivel_Académico)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NA Nivel Académico");
            entity.Property(e => e.OSC_Empleados_Convenio)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OSC Empleados Convenio");
            entity.Property(e => e.POZ_Trabajador_de_pozo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("POZ Trabajador de pozo");
            entity.Property(e => e.SEC_Aportantes_Osecac)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEC Aportantes Osecac");
            entity.Property(e => e.SER_Caracter_de_los_serv)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SER Caracter de los serv");
            entity.Property(e => e.TD_Tarea_desemp_p_recib)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TD Tarea desemp.p/recib");
            entity.Property(e => e.TIC_Tickets_Restaurant)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIC Tickets Restaurant");
            entity.Property(e => e.VEN_Marca_de_vendedor)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VEN Marca de vendedor");
        });

        modelBuilder.Entity<BI_RH_CapacitacionesAtributos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BI_RH_CapacitacionesAtributos");

            entity.Property(e => e.IdCapacitacion)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e._01_Tipo_de_Capacitación)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("01 Tipo de Capacitación");
            entity.Property(e => e._02_Grado_de_Capacitac_)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("02 Grado de Capacitac.");
        });

        modelBuilder.Entity<BI_RH_ElementosAtributos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BI_RH_ElementosAtributos");

            entity.Property(e => e.ART_Elemento_de_ART)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ART Elemento de ART");
            entity.Property(e => e.BU_Bienes_de_uso)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BU Bienes de uso");
            entity.Property(e => e.DCL_Dispositivo_control)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DCL Dispositivo control");
            entity.Property(e => e.IdElemento)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.MDL_Modelo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MDL Modelo");
            entity.Property(e => e.MRC_Marca)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MRC Marca");
            entity.Property(e => e.PC_Puesto_de_trabajo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PC Puesto de trabajo");
            entity.Property(e => e.TEL_Teléfono_celular)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TEL Teléfono celular");
        });

        modelBuilder.Entity<BL2_GANANCIASANEXO2>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ACUMULADO).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.IMPORTE).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.PORCENTAJE).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<BL_ACTIVIDADES>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Actividad, "UN_BL_ACTIVIDADES")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_ACUMLEGAJOSINI>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 5)");

            entity.HasOne(d => d.idAcumuladorNavigation).WithMany()
                .HasForeignKey(d => d.idAcumulador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_ACUMLEGAJOSINI_BL_ACUMULADORES");

            entity.HasOne(d => d.idLegajoNavigation).WithMany()
                .HasForeignKey(d => d.idLegajo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_ACUMLEGAJOSINI_BL_LEGAJOS");
        });

        modelBuilder.Entity<BL_ACUMSASOCIADOS>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdConcepto, e.IdAcumulador }, "UN_BL_ACUMSASOCIADOS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Operacion).HasDefaultValue((short)1);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdAcumuladorNavigation).WithMany()
                .HasForeignKey(d => d.IdAcumulador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_ACUMSASOCIADOS_BL_ACUMULADORES");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany()
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_ACUMSASOCIADOS_BL_CONCEPTOS");
        });

        modelBuilder.Entity<BL_ACUMULADORES>(entity =>
        {
            entity.HasKey(e => e.IdAcumulador)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("CTRL_ACUMULADORES"));

            entity.HasIndex(e => e.CodAcumulador, "UN_BL_ACUMULADORES")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.ConsideraImpProrrateados, "bl_acumuladores_consideraImpProrrateados").HasFillFactor(90);

            entity.Property(e => e.IdAcumulador).ValueGeneratedNever();
            entity.Property(e => e.AniosAConsiderar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAcumulador)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MesesAConsiderar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoFecMesActual)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("L")
                .IsFixedLength();
        });

        modelBuilder.Entity<BL_ALIASTIPOLIQ>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoLiq)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_ANEXO_LIQUIDACIONES>(entity =>
        {
            entity.HasKey(e => new { e.IdLiquidacion, e.IdLegajo }).HasFillFactor(90);

            entity.Property(e => e.BancoPagoCod)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.BancoPagoDesc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CBU)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DescSituacion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FecBaseAnt).HasColumnType("smalldatetime");
            entity.Property(e => e.FecBaseIndem).HasColumnType("datetime");
            entity.Property(e => e.FecEgreso).HasColumnType("datetime");
            entity.Property(e => e.FecIngreso).HasColumnType("datetime");
            entity.Property(e => e.LugarTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LugarTrabajoCodigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.ModContratacionDesc)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.NroInscrLegajo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocialCod)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocialDesc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PagoFecha).HasColumnType("datetime");
            entity.Property(e => e.PagoLugar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ZonaDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_AUDITORIA_ALIAS>(entity =>
        {
            entity.HasKey(e => new { e.Tabla, e.Campo });

            entity.Property(e => e.Campo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Alias)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_AUDITORIA_CAB>(entity =>
        {
            entity.HasKey(e => e.IdAuditoria).HasName("PK-IdAuditoria");

            entity.Property(e => e.ABM)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComputerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DescProg)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Origen)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PeriodoGanancia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Vigencia)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_AUDITORIA_CONSULTA>(entity =>
        {
            entity.HasKey(e => new { e.Maestro, e.Detalle, e.Campo }).HasName("PK_BL_AUDITORIA_CONSULTA_1");

            entity.Property(e => e.Maestro)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Detalle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Campo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BL_AUDITORIA_DET>(entity =>
        {
            entity.Property(e => e.ABM)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Campo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.New_Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.New_Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.New_Valor).HasColumnType("text");
            entity.Property(e => e.Old_Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Old_Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Old_Valor).HasColumnType("text");
            entity.Property(e => e.Registro).HasDefaultValue(0);

            entity.HasOne(d => d.IdAuditoriaNavigation).WithMany(p => p.BL_AUDITORIA_DET)
                .HasForeignKey(d => d.IdAuditoria)
                .HasConstraintName("FK_BL_AUDITORIA_DET_BL_AUDITORIA_CAB");
        });

        modelBuilder.Entity<BL_AUDITORIA_MAESTROS>(entity =>
        {
            entity.HasKey(e => e.IdMaestro);

            entity.Property(e => e.CodMaestro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Maestro)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_AUDITORIA_TXT>(entity =>
        {
            entity.HasKey(e => e.IdAuditoria);

            entity.Property(e => e.IdAuditoria).ValueGeneratedNever();
            entity.Property(e => e.TextoXml).HasColumnType("text");

            entity.HasOne(d => d.IdAuditoriaNavigation).WithOne(p => p.BL_AUDITORIA_TXT)
                .HasForeignKey<BL_AUDITORIA_TXT>(d => d.IdAuditoria)
                .HasConstraintName("FK_BL_AUDITORIA_CAB_BL_AUDITORIA_TXT");
        });

        modelBuilder.Entity<BL_AUXNUMEROS>(entity =>
        {
            entity.HasKey(e => new { e.TipoVec, e.Elemento })
                .HasName("PK__BL_AUXNUMEROS__314D4EA8")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.TipoVec)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Numero)
                .HasMaxLength(13)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_AutogestionAccesoDenegado>(entity =>
        {
            entity.HasKey(e => e.IdPersona);

            entity.Property(e => e.IdPersona).ValueGeneratedNever();
        });

        modelBuilder.Entity<BL_CONCEPTOS>(entity =>
        {
            entity.HasKey(e => e.IdConcepto)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.ClaseConcepto, e.NroConcepto }, "UN_BL_CONCEPTOS")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.TipoProrrateoPeriodos, "bl_conceptos_tipoProrrateoPeriodos").HasFillFactor(90);

            entity.Property(e => e.IdConcepto).ValueGeneratedNever();
            entity.Property(e => e.CodVarEnRec)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExprFormula).HasColumnType("text");
            entity.Property(e => e.Mes1).HasDefaultValue(true);
            entity.Property(e => e.Mes10).HasDefaultValue(true);
            entity.Property(e => e.Mes11).HasDefaultValue(true);
            entity.Property(e => e.Mes12).HasDefaultValue(true);
            entity.Property(e => e.Mes2).HasDefaultValue(true);
            entity.Property(e => e.Mes3).HasDefaultValue(true);
            entity.Property(e => e.Mes4).HasDefaultValue(true);
            entity.Property(e => e.Mes5).HasDefaultValue(true);
            entity.Property(e => e.Mes6).HasDefaultValue(true);
            entity.Property(e => e.Mes7).HasDefaultValue(true);
            entity.Property(e => e.Mes8).HasDefaultValue(true);
            entity.Property(e => e.Mes9).HasDefaultValue(true);
            entity.Property(e => e.ObsEnRecibo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PeriodoAnt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.TipoProrrateo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("C")
                .IsFixedLength();
            entity.Property(e => e.TipoProrrateoPeriodos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength();
            entity.Property(e => e.unEnRecibo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdVariableNavigation).WithMany(p => p.BL_CONCEPTOS)
                .HasForeignKey(d => d.IdVariable)
                .HasConstraintName("FK_BL_CONCEPTOS_BL_VARIABLESDEFINIBLES");
        });

        modelBuilder.Entity<BL_CONCEPTOSTIPOLIQ>(entity =>
        {
            entity.HasKey(e => new { e.IdConcepto, e.IdLiqTipo })
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.BL_CONCEPTOSTIPOLIQ)
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_CONCEPTOSTIPOLIQ_BL_CONCEPTOS");

            entity.HasOne(d => d.IdLiqTipoNavigation).WithMany(p => p.BL_CONCEPTOSTIPOLIQ)
                .HasForeignKey(d => d.IdLiqTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_CONCEPTOSTIPOLIQ_BL_LIQUIDACIONESTIPOS");
        });

        modelBuilder.Entity<BL_CONDICIONESLAB>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.CondLaboral, "UN_BL_CONDICIONESLAB")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_CONVENIOS>(entity =>
        {
            entity.HasKey(e => e.IdConvenio)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.CodConvenio, "UN_BL_CONVENIOS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdConvenio).ValueGeneratedNever();
            entity.Property(e => e.CodAtrAdicional)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodConvenio)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ConvencionadoSIJP).HasDefaultValue((byte)1);
            entity.Property(e => e.Denominacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DiasVacsMenorA6Meses).HasDefaultValue(20);
            entity.Property(e => e.HorasLabsDia).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.HorasLabsMes).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TopeIndem).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<BL_CONVENIOSVAC>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdConvenio, e.Anios }, "BL_CONVENIOSVAC_IDCONVENIO_ANIOS").HasFillFactor(90);

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdConvenioNavigation).WithMany()
                .HasForeignKey(d => d.IdConvenio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_CONVENIOSVAC_BL_CONVENIOS");
        });

        modelBuilder.Entity<BL_CONVENIOSVAL>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdConvenio, e.Anios }, "BL_CONVENIOSVAL_IDCONVENIO_ANIOS").HasFillFactor(90);

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 5)");

            entity.HasOne(d => d.IdConvenioNavigation).WithMany()
                .HasForeignKey(d => d.IdConvenio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_CONVENIOSVAL_BL_CONVENIOS");
        });

        modelBuilder.Entity<BL_CONVENIOSVAL2>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdConvenio, e.Anios }, "BL_CONVENIOSVAL2_IDCONVENIO_ANIOS").HasFillFactor(90);

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 5)");

            entity.HasOne(d => d.IdConvenioNavigation).WithMany()
                .HasForeignKey(d => d.IdConvenio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_CONVENIOSVAL2_BL_CONVENIOS");
        });

        modelBuilder.Entity<BL_DOCSTEXTO>(entity =>
        {
            entity.HasKey(e => e.IdDocTexto)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.CodDocTexto, "UN_BL_DOCSTEXTO")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdDocTexto).ValueGeneratedNever();
            entity.Property(e => e.CodDocTexto)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Extension)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Texto).HasColumnType("image");
        });

        modelBuilder.Entity<BL_EGRESOS_SIMULACION>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<BL_EMPLEADOSACARGO>(entity =>
        {
            entity.HasKey(e => new { e.IdManager, e.IdLegajo });

            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdLegajoNavigation).WithMany(p => p.BL_EMPLEADOSACARGOIdLegajoNavigation)
                .HasForeignKey(d => d.IdLegajo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_EMPLEADOSACARGO_BL_LEGAJOS2");

            entity.HasOne(d => d.IdManagerNavigation).WithMany(p => p.BL_EMPLEADOSACARGOIdManagerNavigation)
                .HasForeignKey(d => d.IdManager)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_EMPLEADOSACARGO_BL_LEGAJOS");
        });

        modelBuilder.Entity<BL_EMPRESASGRUPOS>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.NOMBRE)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<BL_EMPRESASPERSEVENTUAL>(entity =>
        {
            entity.HasKey(e => e.CodEmpEventual).HasFillFactor(90);

            entity.Property(e => e.CodEmpEventual)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CUIT)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodHab)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Domicilio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_ESCOLARIDADES>(entity =>
        {
            entity.HasKey(e => e.IdEscolaridad)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.CodEscolaridad, "UN_BL_ESCOLARIDADES")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdEscolaridad).ValueGeneratedNever();
            entity.Property(e => e.CodEscolaridad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_ESTADOSCIVILES>(entity =>
        {
            entity.HasKey(e => e.IdEstado)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.NroEstado, "UN_BL_ESTADOSCIVILES")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdEstado).ValueGeneratedNever();
            entity.Property(e => e.Denominacion)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_FAMILIARES>(entity =>
        {
            entity.HasKey(e => e.IdFamiliar)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.IdPersona, "BL_FAMILIARES_IDPERSONA").HasFillFactor(90);

            entity.Property(e => e.IdFamiliar).ValueGeneratedNever();
            entity.Property(e => e.AnioEnCurso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoCasada)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.CUIL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodDoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoBaja)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DocNro)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCalle)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCodPos)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioDepto)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioLoc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioNro)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioPiso)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.FecACargo).HasColumnType("smalldatetime");
            entity.Property(e => e.FecNacimiento).HasColumnType("smalldatetime");
            entity.Property(e => e.FecVencDeducGan).HasColumnType("datetime");
            entity.Property(e => e.GeneraDeducGan).HasDefaultValue(true);
            entity.Property(e => e.GeneraDerAF).HasDefaultValue(true);
            entity.Property(e => e.Nombres)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ParentescoSIRADIGDesc)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Secuencia).ValueGeneratedOnAdd();
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.TipoVencAsigFam)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P")
                .IsFixedLength();
            entity.Property(e => e.TipoVencDeducGan)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P")
                .IsFixedLength();
            entity.Property(e => e.TipoVencObraSoc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P")
                .IsFixedLength();

            entity.HasOne(d => d.CodDocNavigation).WithMany(p => p.BL_FAMILIARES)
                .HasForeignKey(d => d.CodDoc)
                .HasConstraintName("FK_BL_FAMILIARES_TIPODOC");

            entity.HasOne(d => d.IdEscolaridadNavigation).WithMany(p => p.BL_FAMILIARES)
                .HasForeignKey(d => d.IdEscolaridad)
                .HasConstraintName("FK_BL_FAMILIARES_BL_ESCOLARIDADES");

            entity.HasOne(d => d.IdNacionalidadNavigation).WithMany(p => p.BL_FAMILIARES)
                .HasForeignKey(d => d.IdNacionalidad)
                .HasConstraintName("FK_BL_FAMILIARES_BL_NACIONALIDADES");

            entity.HasOne(d => d.IdParentescoNavigation).WithMany(p => p.BL_FAMILIARES)
                .HasForeignKey(d => d.IdParentesco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_FAMILIARES_BL_PARENTESCOS");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.BL_FAMILIARES)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_FAMILIARES_BL_PERSONAS");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.BL_FAMILIARES)
                .HasForeignKey(d => d.IdProvincia)
                .HasConstraintName("FK_BL_FAMILIARES_BL_PROVINCIAS");
        });

        modelBuilder.Entity<BL_FAMILIARESPERIODOSACARGO>(entity =>
        {
            entity.HasKey(e => new { e.idFamiliar, e.FecACargoDesde, e.ACargoEn }).HasFillFactor(90);

            entity.Property(e => e.FecACargoDesde).HasColumnType("smalldatetime");
            entity.Property(e => e.ACargoEn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FecACargoHasta).HasColumnType("smalldatetime");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.fechaLimite).HasColumnType("datetime");
            entity.Property(e => e.porcentajeDeduccion).HasDefaultValue(100);
        });

        modelBuilder.Entity<BL_FAMILIARES_INACTIVOS>(entity =>
        {
            entity.HasKey(e => e.IdFamiliar).IsClustered(false);

            entity.Property(e => e.IdFamiliar).ValueGeneratedNever();
            entity.Property(e => e.AnioEnCurso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoCasada)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.CUIL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodDoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoBaja)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DocNro)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCalle)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCodPos)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioDepto)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioLoc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioNro)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioPiso)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.FecACargo).HasColumnType("smalldatetime");
            entity.Property(e => e.FecNacimiento).HasColumnType("smalldatetime");
            entity.Property(e => e.FecVencDeducGan).HasColumnType("datetime");
            entity.Property(e => e.GeneraDeducGan).HasDefaultValue(true);
            entity.Property(e => e.GeneraDerAF).HasDefaultValue(true);
            entity.Property(e => e.Nombres)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ParentescoSIRADIGDesc)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Secuencia).ValueGeneratedOnAdd();
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.TipoVencAsigFam)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P")
                .IsFixedLength();
            entity.Property(e => e.TipoVencDeducGan)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P")
                .IsFixedLength();
            entity.Property(e => e.TipoVencObraSoc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P")
                .IsFixedLength();
        });

        modelBuilder.Entity<BL_FERIADOS>(entity =>
        {
            entity.HasKey(e => e.ANIO).IsClustered(false);

            entity.Property(e => e.ANIO).ValueGeneratedNever();
        });

        modelBuilder.Entity<BL_FERIADOS_DETALLE>(entity =>
        {
            entity.HasKey(e => new { e.ANIO, e.FECHA }).IsClustered(false);

            entity.Property(e => e.FECHA).HasColumnType("datetime");
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.ANIONavigation).WithMany(p => p.BL_FERIADOS_DETALLE)
                .HasForeignKey(d => d.ANIO)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_FERIADOS_BL_FERIADOS_DETALLE");
        });

        modelBuilder.Entity<BL_FILTROS_NOVEDADESCONSULTA>(entity =>
        {
            entity.HasKey(e => new { e.CodFiltro, e.CodEmp, e.Usuario, e.TipoFiltro })
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.CodFiltro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TipoFiltro)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Filtro)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_FUNCIONESEXTERNAS>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.CODIGO, "UN_BL_FUNCIONESEXTERNAS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.CODIGO)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.COMMANDTEXT)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PARAMETROS)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.SINTAXIS)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.TIPOFECHA)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P");
        });

        modelBuilder.Entity<BL_GANANCIAS>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.ANIO, "UN_BL_GANANCIAS")
                .IsUnique()
                .HasFillFactor(90);
        });

        modelBuilder.Entity<BL_GANANCIASANEXO1>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.ANIO, e.CODIGO }, "UN_BL_GANANCIASANEXO1")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.ABRIL).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.AGOSTO).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ANUAL).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CONCEPTO)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.DICIEMBRE).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ENERO).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.FEBRERO).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.JULIO).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.JUNIO).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.MARZO).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.MAYO).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.NOVIEMBRE).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.OCTUBRE).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.SEPTIEMBRE).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<BL_GANANCIASANEXO2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb => tb.HasTrigger("TG_VALORAFIP"));

            entity.Property(e => e.ACUMULADO).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.IMPORTE).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.PORCENTAJE).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<BL_GANANCIASANEXO2_CEDULAR>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ACUMULADO).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.IMPORTE).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.PORCENTAJE).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<BL_GANANCIASANEXO5>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IMPORTE).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.PORCENTAJE).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<BL_GRUPOS>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("PK_GRUPOS")
                .HasFillFactor(90);

            entity.HasIndex(e => e.IdGrupo, "UN_BL_GRUPOS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Formula).HasColumnType("text");
            entity.Property(e => e.TipoGrupo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("V")
                .IsFixedLength();
        });

        modelBuilder.Entity<BL_GRUPOSDEP>(entity =>
        {
            entity.HasKey(e => new { e.IdGrupo, e.IdGrupoDep }).HasFillFactor(90);

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdGrupoDepNavigation).WithMany(p => p.BL_GRUPOSDEP)
                .HasPrincipalKey(p => p.IdGrupo)
                .HasForeignKey(d => d.IdGrupoDep)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_GRUPOSDEP_GRUPOS");
        });

        modelBuilder.Entity<BL_GRUPOSVISOR4TA>(entity =>
        {
            entity.HasKey(e => e.Grupo);

            entity.Property(e => e.Grupo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrupoDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_Ganancias_AnexoIV>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.VigenciaDesde).HasColumnType("datetime");
            entity.Property(e => e.VigenciaHasta).HasColumnType("datetime");
        });

        modelBuilder.Entity<BL_INCAPACIDADES>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Incapacidad, "UN_BL_INCAPACIDADES")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_JOB>(entity =>
        {
            entity.HasKey(e => new { e.Tarea, e.CodEmp });

            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Frecuencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P");
            entity.Property(e => e.Habilitada).HasDefaultValue(true);
            entity.Property(e => e.Opciones).HasColumnType("xml");
        });

        modelBuilder.Entity<BL_LEGAJOS>(entity =>
        {
            entity.HasKey(e => e.IdLegajo)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.CodEmp, e.Legajo }, "UN_BL_LEGAJOS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdLegajo).ValueGeneratedNever();
            entity.Property(e => e.AcAnRet).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.AporteVolunt).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CAT)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CapitalRecomp).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Cargo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodEmp).HasDefaultValue((short)1);
            entity.Property(e => e.CodigoBaja)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ExcedenteAOS).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ExcedenteASS).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.FecBaseAnt).HasColumnType("smalldatetime");
            entity.Property(e => e.FecBaseIndem).HasColumnType("datetime");
            entity.Property(e => e.FecEgreso).HasColumnType("smalldatetime");
            entity.Property(e => e.FecIngreso).HasColumnType("smalldatetime");
            entity.Property(e => e.FecJubilacion).HasColumnType("smalldatetime");
            entity.Property(e => e.HabilitadoAutogestion).HasDefaultValue(true);
            entity.Property(e => e.Legajo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.ObservsLibro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Oficina)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PorApoAdi).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PorTareaDif).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.PublicarRecibos).HasDefaultValue(true);
            entity.Property(e => e.RedUltLiq).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Regimen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SueldoBasicoRec).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TareaDesemp)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TelDirecto)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.TelInterno)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.email)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CodEmpNavigation).WithMany(p => p.BL_LEGAJOS)
                .HasForeignKey(d => d.CodEmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bl_Legajos_Codemp");

            entity.HasOne(d => d.IdConvenioNavigation).WithMany(p => p.BL_LEGAJOS)
                .HasForeignKey(d => d.IdConvenio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_LEGAJOS_BL_CONVENIOS");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.BL_LEGAJOS)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_LEGAJOS_BL_PERSONAS");

            entity.HasOne(d => d.IdSituacionNavigation).WithMany(p => p.BL_LEGAJOS)
                .HasForeignKey(d => d.IdSituacion)
                .HasConstraintName("FK_BL_LEGAJOS_BL_SITUACIONESREVISTA");
        });

        modelBuilder.Entity<BL_LEGAJOSATRIBUTOS>(entity =>
        {
            entity.HasKey(e => new { e.IdLegajo, e.CodAtr }).HasFillFactor(90);

            entity.HasIndex(e => new { e.CodAtr, e.CodAtrVal }, "BL_LEGAJOSATRIBUTOS_CODATR_CODATRVAL").HasFillFactor(90);

            entity.HasIndex(e => new { e.IdLegajo, e.CodAtr, e.CodAtrVal }, "bl_legajosatributos_codatrval").HasFillFactor(90);

            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.CodAtrNavigation).WithMany(p => p.BL_LEGAJOSATRIBUTOS)
                .HasForeignKey(d => d.CodAtr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_LEGAJOSATRIBUTOS_ATRIBUTOS");

            entity.HasOne(d => d.IdLegajoNavigation).WithMany(p => p.BL_LEGAJOSATRIBUTOS)
                .HasForeignKey(d => d.IdLegajo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_LEGAJOSATRIBUTOS_BL_LEGAJOS");

            entity.HasOne(d => d.ATRIBUTOSVAL).WithMany(p => p.BL_LEGAJOSATRIBUTOS)
                .HasForeignKey(d => new { d.CodAtr, d.CodAtrVal })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_LEGAJOSATRIBUTOS_ATRIBUTOSVAL");
        });

        modelBuilder.Entity<BL_LEGAJOSVACS>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DiasAcr).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.DiasAsig).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.DiasGozados).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.DiasLiq).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.FecCalculo).HasColumnType("datetime");

            entity.HasOne(d => d.IdLegajoNavigation).WithMany()
                .HasForeignKey(d => d.IdLegajo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_LEGAJOSVACS_BL_LEGAJOS");
        });

        modelBuilder.Entity<BL_LEGAJOSVISTAS>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.NombreNodo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdVistaNavigation).WithMany()
                .HasForeignKey(d => d.IdVista)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_LEGAJOSVISTAS_BL_VISTAS");
        });

        modelBuilder.Entity<BL_LIQEXISTENTES_SIMULACION>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<BL_LIQUIDACIONES>(entity =>
        {
            entity.HasKey(e => e.IdLiquidacion)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.MesLiq, e.IdLiquidacion }, "BL_LIQUIDACIONES_MESLIQ_IDLIQUIDACION").HasFillFactor(90);

            entity.Property(e => e.CodEmp).HasDefaultValue((short)1);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaDesde).HasColumnType("datetime");
            entity.Property(e => e.FechaHasta).HasColumnType("datetime");
            entity.Property(e => e.MesLiq).HasColumnType("smalldatetime");
            entity.Property(e => e.MesPago).HasColumnType("smalldatetime");

            entity.HasOne(d => d.IdLiqTipoNavigation).WithMany(p => p.BL_LIQUIDACIONES)
                .HasForeignKey(d => d.IdLiqTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_LIQUIDACIONES_BL_LIQUIDACIONESTIPOS");
        });

        modelBuilder.Entity<BL_LIQUIDACIONESACUMS>(entity =>
        {
            entity.HasKey(e => new { e.IdLegajo, e.IdAcumulador, e.MesLiq, e.IdLiqTipo }).HasFillFactor(90);

            entity.Property(e => e.MesLiq).HasColumnType("smalldatetime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Parametro)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<BL_LIQUIDACIONESATRS>(entity =>
        {
            entity.HasKey(e => new { e.IdLegajo, e.CodAtr, e.MesLiq, e.IdLiqTipo }).HasFillFactor(90);

            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MesLiq).HasColumnType("smalldatetime");
            entity.Property(e => e.CodAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Parametro)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_LIQUIDACIONESATRS_SIMULACION>(entity =>
        {
            entity.HasKey(e => new { e.IdLegajo, e.CodAtr, e.MesLiq, e.IdLiqTipo }).HasFillFactor(90);

            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MesLiq).HasColumnType("smalldatetime");
            entity.Property(e => e.CodAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Parametro)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_LIQUIDACIONESDET>(entity =>
        {
            entity.HasKey(e => new { e.IdLiquidacion, e.IdLegajo, e.IdConcepto })
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.IdLegajo, e.IdLiquidacion, e.IdConcepto, e.Importe }, "bl_liquidacionesdet_idlegajo")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Auxiliar).HasDefaultValue((byte)0);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CodCueAcrNavigation).WithMany(p => p.BL_LIQUIDACIONESDETCodCueAcrNavigation)
                .HasForeignKey(d => d.CodCueAcr)
                .HasConstraintName("FK_BL_LIQUIDACIONESDET_CUENTAS1");

            entity.HasOne(d => d.CodCueDeuNavigation).WithMany(p => p.BL_LIQUIDACIONESDETCodCueDeuNavigation)
                .HasForeignKey(d => d.CodCueDeu)
                .HasConstraintName("FK_BL_LIQUIDACIONESDET_CUENTAS");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.BL_LIQUIDACIONESDET)
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_LIQUIDACIONESDET_BL_CONCEPTOS");

            entity.HasOne(d => d.IdLegajoNavigation).WithMany(p => p.BL_LIQUIDACIONESDET)
                .HasForeignKey(d => d.IdLegajo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_LIQUIDACIONESDET_BL_LEGAJOS");

            entity.HasOne(d => d.IdLiquidacionNavigation).WithMany(p => p.BL_LIQUIDACIONESDET)
                .HasForeignKey(d => d.IdLiquidacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_LIQUIDACIONESDET_BL_LIQUIDACIONES1");
        });

        modelBuilder.Entity<BL_LIQUIDACIONESDET_CENTROAPP>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdLiquidacion, e.IdLegajo, e.IdConcepto }, "BL_LIQUIDACIONESDET_CENTROAPP_IDLIQUIDACION_IDLEGAJO_IDCONCEPTO").HasFillFactor(90);

            entity.HasIndex(e => new { e.IdLiquidacion, e.IdLegajo }, "BL_LIQUIDACIONESDET_CENTROAPP_IDLIQ_IDLEG").HasFillFactor(90);

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TipoProrrateo)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.HasOne(d => d.BL_LIQUIDACIONESDET).WithMany()
                .HasForeignKey(d => new { d.IdLiquidacion, d.IdLegajo, d.IdConcepto })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_LIQUIDACIONESDET_CENTROSAPP_BL_LIQUIDACIONESDET");
        });

        modelBuilder.Entity<BL_LIQUIDACIONESDET_CENTROAPP_SIMULACION>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TipoProrrateo)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_LIQUIDACIONESDET_SIMULACION>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_LIQUIDACIONESPAGDEP>(entity =>
        {
            entity.HasKey(e => e.IdLiquidacion)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.IdLiquidacion).ValueGeneratedNever();
            entity.Property(e => e.PagoFecha).HasColumnType("smalldatetime");
            entity.Property(e => e.PagoLugar)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReciboTexto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.UltDepBanco)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.UltDepFecha).HasColumnType("smalldatetime");
            entity.Property(e => e.UltDepMesCorresp).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<BL_LIQUIDACIONESTIPOS>(entity =>
        {
            entity.HasKey(e => e.IdLiqTipo)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.IdLiqTipo).ValueGeneratedNever();
            entity.Property(e => e.CodLiq)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_LIQUIDACIONESVACS>(entity =>
        {
            entity.HasKey(e => new { e.IdLiquidacion, e.IdLegajo, e.IdOcurrencia });

            entity.Property(e => e.ImporteLiq).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<BL_LIQUIDACIONESVARS>(entity =>
        {
            entity.HasKey(e => new { e.IdLegajo, e.MesLiq, e.IdLiqTipo, e.CodVariable })
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.IdLegajo, e.MesLiq, e.IdLiqTipo, e.CodVariable }, "BL_LIQUIDACIONESVARS_AUX_ID")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.MesLiq).HasColumnType("smalldatetime");
            entity.Property(e => e.CodVariable)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Parametro)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_LIQUIDACIONESVARS_SIMULACION>(entity =>
        {
            entity.HasKey(e => new { e.IdLegajo, e.MesLiq, e.IdLiqTipo, e.CodVariable })
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.IdLegajo, e.MesLiq, e.IdLiqTipo, e.CodVariable }, "BL_LIQUIDACIONESVARS_SIMULACION_ID")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.MesLiq).HasColumnType("smalldatetime");
            entity.Property(e => e.CodVariable)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Parametro)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_LIQUIDACIONES_4ta>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Codigo4ta)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion4ta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaYHora)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MesPago).HasColumnType("smalldatetime");
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<BL_LOCKDATOSHISTORICOS>(entity =>
        {
            entity.HasKey(e => new { e.IdLiqTipo, e.MesLiq, e.ComputerName, e.CodEmp });

            entity.Property(e => e.MesLiq).HasColumnType("smalldatetime");
            entity.Property(e => e.ComputerName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_LSD_CAB>(entity =>
        {
            entity.HasKey(e => e.NroLiqAFIP);

            entity.Property(e => e.NroLiqAFIP).ValueGeneratedNever();
            entity.Property(e => e.Cuit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaDesde).HasColumnType("datetime");
            entity.Property(e => e.FechaHasta).HasColumnType("datetime");
            entity.Property(e => e.FechaPresentacion).HasColumnType("datetime");
            entity.Property(e => e.IdEnvio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdLegajos).IsUnicode(false);
            entity.Property(e => e.MesPago).HasColumnType("datetime");
            entity.Property(e => e.TipoCodigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoLiq)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_LSD_DET>(entity =>
        {
            entity.HasKey(e => new { e.NroLiqAFIP, e.IdLinea });

            entity.Property(e => e.IdLinea).ValueGeneratedOnAdd();
            entity.Property(e => e.Linea).IsUnicode(false);
            entity.Property(e => e.TipoReg)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.HasOne(d => d.NroLiqAFIPNavigation).WithMany(p => p.BL_LSD_DET)
                .HasForeignKey(d => d.NroLiqAFIP)
                .HasConstraintName("FK_BL_LSD_DET_BL_LSD_CAB");
        });

        modelBuilder.Entity<BL_LUGARESTRABAJO>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Codigo, "UN_BL_LUGARESTRABAJO")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Codigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PagoLugar)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_LegajosAtributosAdic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BL_LegajosAtributosAdic");

            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CodAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_MODCONTRATACIONES>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.ModContratacion, "UN_BL_MODCONTRATACIONES")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_MONEDAS>(entity =>
        {
            entity.HasKey(e => e.Valor)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<BL_NACIONALIDADES>(entity =>
        {
            entity.HasKey(e => e.IdNacionalidad)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.NroNacionalidad, "UN_BL_NACIONALIDADES")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdNacionalidad).ValueGeneratedNever();
            entity.Property(e => e.Denominacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_NOVEDADES>(entity =>
        {
            entity.HasKey(e => e.IdOcurrencia)
                .HasName("PK_BL_SUCESOSOCURRENCIAS")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.VtoMesAnioDesde, "BL_NOVEDADES_VTOMESANIODESDE").HasFillFactor(90);

            entity.HasIndex(e => new { e.IdOcurrencia, e.VtoMesAnioDesde, e.IdLiqTipo, e.FechaReg, e.CodEmp }, "bl_novedades_idocurrencia").HasFillFactor(90);

            entity.Property(e => e.IdOcurrencia).ValueGeneratedNever();
            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodEmp).HasDefaultValue((short)1);
            entity.Property(e => e.Documento).HasColumnType("image");
            entity.Property(e => e.FecOcurrencia).HasColumnType("datetime");
            entity.Property(e => e.FecVtoContrato).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaReg)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LicFecDesde).HasColumnType("smalldatetime");
            entity.Property(e => e.LicFecHasta).HasColumnType("smalldatetime");
            entity.Property(e => e.LicFecReintegro).HasColumnType("smalldatetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.VtoMesAnioDesde).HasColumnType("smalldatetime");
            entity.Property(e => e.VtoMesAnioHasta).HasColumnType("smalldatetime");
            entity.Property(e => e.codatr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codatrval)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CodEmpNavigation).WithMany(p => p.BL_NOVEDADES)
                .HasForeignKey(d => d.CodEmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bl_novedades_Codemp");

            entity.HasOne(d => d.IdLiqTipoNavigation).WithMany(p => p.BL_NOVEDADES)
                .HasForeignKey(d => d.IdLiqTipo)
                .HasConstraintName("FK_BL_NOVEDADES_BL_LIQUIDACIONESTIPOS");

            entity.HasOne(d => d.IdSucesoNavigation).WithMany(p => p.BL_NOVEDADES)
                .HasForeignKey(d => d.IdSuceso)
                .HasConstraintName("FK_BL_NOVEDADES_BL_SUCESOS");
        });

        modelBuilder.Entity<BL_NOVEDADESCONCEPTOS>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdOcurrencia, e.IdConcepto }, "BL_NOVEDADESCONCEPTOS_IDOCU_IDCON").HasFillFactor(90);

            entity.HasIndex(e => new { e.Liquidar, e.IdOcurrencia, e.IdConcepto }, "bl_novedadesConceptos_Liquidar")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.IdConcepto, e.IdOcurrencia, e.Liquidar }, "bl_novedadesConceptos_idOcurrencia").HasFillFactor(90);

            entity.Property(e => e.IdOcurrencia).HasDefaultValue(1);
            entity.Property(e => e.Liquidar).HasDefaultValue((byte)1);
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdConceptoNavigation).WithMany()
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_NOVEDADESCONCEPTOS_BL_CONCEPTOS");

            entity.HasOne(d => d.IdOcurrenciaNavigation).WithMany()
                .HasForeignKey(d => d.IdOcurrencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_NOVEDADESCONCEPTOS_BL_NOVEDADES");
        });

        modelBuilder.Entity<BL_NOVEDADESCONCEPTOS_SUSPENSION>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdOcurrencia, e.IdConcepto }, "BL_NOVEDADESCONCEPTOS_SUSPENSION_IDOCU_IDCON").HasFillFactor(90);

            entity.HasIndex(e => new { e.Liquidar, e.IdOcurrencia, e.IdConcepto }, "BL_NOVEDADESCONCEPTOS_SUSPENSION_Liquidar")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.IdConcepto, e.IdOcurrencia, e.Liquidar }, "BL_NOVEDADESCONCEPTOS_SUSPENSION_idOcurrencia").HasFillFactor(90);

            entity.Property(e => e.IdOcurrencia).HasDefaultValue(1);
            entity.Property(e => e.Liquidar).HasDefaultValue((byte)1);
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdConceptoNavigation).WithMany()
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_NOVEDADESCONCEPTOS_SUSPENSION_BL_CONCEPTOS");

            entity.HasOne(d => d.IdOcurrenciaNavigation).WithMany()
                .HasForeignKey(d => d.IdOcurrencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_NOVEDADESCONCEPTOS_SUSPENSION_BL_NOVEDADES_SUSPENSION");
        });

        modelBuilder.Entity<BL_NOVEDADESDOCUMENTOS>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Extension)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Texto).HasColumnType("image");
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_NOVEDADESEVENTUAL>(entity =>
        {
            entity.HasKey(e => e.idOcurrencia)
                .HasName("PK_BL_NOVEDADESPEREVENTUAL")
                .HasFillFactor(90);

            entity.Property(e => e.idOcurrencia).ValueGeneratedNever();
            entity.Property(e => e.CodEmpEventual)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Factura)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FecOcurrencia).HasColumnType("smalldatetime");
            entity.Property(e => e.Observacion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Periodo).HasColumnType("smalldatetime");
            entity.Property(e => e.TotalFactura).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<BL_NOVEDADESGAN>(entity =>
        {
            entity.HasKey(e => e.IdNovedadGan).HasFillFactor(90);

            entity.HasIndex(e => new { e.Anio, e.IdLegajo }, "UN_BL_NOVEDADESGAN")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdNovedadGan).ValueGeneratedNever();
        });

        modelBuilder.Entity<BL_NOVEDADESLEGAJOS>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdOcurrencia, e.IdLegajo, e.codAtr, e.codAtrVal }, "bl_novedadeslegajos_idOcurrencia")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Comentario)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DiasGozados).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.FecBaseAnt).HasColumnType("datetime");
            entity.Property(e => e.FecBaseIndem).HasColumnType("datetime");
            entity.Property(e => e.FecEgreso).HasColumnType("datetime");
            entity.Property(e => e.FecIngreso).HasColumnType("datetime");
            entity.Property(e => e.FecNotifJustif).HasColumnType("smalldatetime");
            entity.Property(e => e.FecPrevNot).HasColumnType("smalldatetime");
            entity.Property(e => e.Nota).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Orden).ValueGeneratedOnAdd();
            entity.Property(e => e.SancionDias).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.codAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdLegajoNavigation).WithMany()
                .HasForeignKey(d => d.IdLegajo)
                .HasConstraintName("FK_BL_NOVEDADESLEGAJOS_BL_LEGAJOS");

            entity.HasOne(d => d.IdOcurrenciaNavigation).WithMany()
                .HasForeignKey(d => d.IdOcurrencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_NOVEDADESLEGAJOS_BL_NOVEDADES");

            entity.HasOne(d => d.ATRIBUTOSVAL).WithMany()
                .HasForeignKey(d => new { d.codAtr, d.codAtrVal })
                .HasConstraintName("FK_BL_NOVEDADESLEGAJOS_ATRIBUTOSVAL");
        });

        modelBuilder.Entity<BL_NOVEDADESLEGAJOS_SUSPENSION>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdOcurrencia, e.IdLegajo, e.codAtr, e.codAtrVal }, "BL_NOVEDADESLEGAJOS_SUSPENSION_idOcurrencia")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Comentario)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DiasGozados).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.FecBaseAnt).HasColumnType("datetime");
            entity.Property(e => e.FecBaseIndem).HasColumnType("datetime");
            entity.Property(e => e.FecEgreso).HasColumnType("datetime");
            entity.Property(e => e.FecIngreso).HasColumnType("datetime");
            entity.Property(e => e.FecNotifJustif).HasColumnType("smalldatetime");
            entity.Property(e => e.FecPrevNot).HasColumnType("smalldatetime");
            entity.Property(e => e.Nota).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Orden).ValueGeneratedOnAdd();
            entity.Property(e => e.SancionDias).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.codAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdLegajoNavigation).WithMany()
                .HasForeignKey(d => d.IdLegajo)
                .HasConstraintName("FK_BL_NOVEDADESLEGAJOS_SUSPENSION_BL_LEGAJOS");

            entity.HasOne(d => d.IdOcurrenciaNavigation).WithMany()
                .HasForeignKey(d => d.IdOcurrencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_NOVEDADESLEGAJOS_SUSPENSION_BL_NOVEDADES_SUSPENSION");

            entity.HasOne(d => d.ATRIBUTOSVAL).WithMany()
                .HasForeignKey(d => new { d.codAtr, d.codAtrVal })
                .HasConstraintName("FK_BL_NOVEDADESLEGAJOS_SUSPENSION_ATRIBUTOSVAL");
        });

        modelBuilder.Entity<BL_NOVEDADESPERSONALEVENTUAL>(entity =>
        {
            entity.HasKey(e => new { e.idOcurrencia, e.idPersonalEventual }).HasFillFactor(90);

            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<BL_NOVEDADESSUSPENDIDAS>(entity =>
        {
            entity.HasKey(e => e.IdSuspension).HasFillFactor(90);

            entity.Property(e => e.IdSuspension).ValueGeneratedNever();
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .IsFixedLength();
            entity.Property(e => e.FechaReg)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.NoLiqFechaDesde).HasColumnType("smalldatetime");
            entity.Property(e => e.NoLiqFechaHasta).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<BL_NOVEDADESVARGAN>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CUIT)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionA)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionB)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Planilla)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .IsFixedLength();
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.VtoMesAnioDesde).HasColumnType("datetime");
            entity.Property(e => e.VtoMesAnioHasta).HasColumnType("datetime");

            entity.HasOne(d => d.IdNovedadGanNavigation).WithMany()
                .HasForeignKey(d => d.IdNovedadGan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_NOVEDADESVARGAN_IdNovedadGan");

            entity.HasOne(d => d.IdVariableNavigation).WithMany()
                .HasForeignKey(d => d.IdVariable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_NOVEDADESVARGAN_IdVariable");
        });

        modelBuilder.Entity<BL_NOVEDADESVARIABLES>(entity =>
        {
            entity.HasKey(e => new { e.IdOcurrencia, e.Id })
                .HasName("PK_BL_NOVEDADESVARIABLES2")
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.codAtrVal, e.codAtr, e.IdOcurrencia }, "BL_NOVEDADESVARIABLES2_Atributo").HasFillFactor(90);

            entity.HasIndex(e => new { e.codAtr, e.codAtrVal }, "BL_NOVEDADESVARIABLES2_CODATR_CODATRVAL").HasFillFactor(90);

            entity.HasIndex(e => e.IdLegajo, "BL_NOVEDADESVARIABLES2_IDLegajo").HasFillFactor(90);

            entity.HasIndex(e => e.IdVariable, "BL_NOVEDADESVARIABLES2_IDVARIABLE").HasFillFactor(90);

            entity.HasIndex(e => e.IdOcurrencia, "BL_NOVEDADESVARIABLES2_idOcurrencia").HasFillFactor(90);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.CodCat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Mes).HasColumnType("datetime");
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.codAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdOcurrenciaNavigation).WithMany(p => p.BL_NOVEDADESVARIABLES)
                .HasForeignKey(d => d.IdOcurrencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_NOVEDADESVARIABLES2_BL_NOVEDADES");

            entity.HasOne(d => d.IdVariableNavigation).WithMany(p => p.BL_NOVEDADESVARIABLES)
                .HasForeignKey(d => d.IdVariable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_NOVEDADESVARIABLES2_BL_VARIABLESDEFINIBLES");
        });

        modelBuilder.Entity<BL_NOVEDADES_DATOSAUX>(entity =>
        {
            entity.HasKey(e => e.IdOcurrencia).HasFillFactor(90);

            entity.Property(e => e.IdOcurrencia).ValueGeneratedNever();
        });

        modelBuilder.Entity<BL_NOVEDADES_SUSPENSION>(entity =>
        {
            entity.HasKey(e => e.IdOcurrencia)
                .HasName("PK_BL_NOVEDADES_SUSPENSION_BL_SUCESOSOCURRENCIAS")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.VtoMesAnioDesde, "BL_NOVEDADES_VTOMESANIODESDE").HasFillFactor(90);

            entity.HasIndex(e => new { e.IdOcurrencia, e.VtoMesAnioDesde, e.IdLiqTipo, e.FechaReg, e.CodEmp }, "BL_NOVEDADES_idocurrencia").HasFillFactor(90);

            entity.Property(e => e.IdOcurrencia).ValueGeneratedNever();
            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodEmp).HasDefaultValue((short)1);
            entity.Property(e => e.Documento).HasColumnType("image");
            entity.Property(e => e.FecOcurrencia).HasColumnType("datetime");
            entity.Property(e => e.FecVtoContrato).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaReg)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LicFecDesde).HasColumnType("smalldatetime");
            entity.Property(e => e.LicFecHasta).HasColumnType("smalldatetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.VtoMesAnioDesde).HasColumnType("smalldatetime");
            entity.Property(e => e.VtoMesAnioHasta).HasColumnType("smalldatetime");
            entity.Property(e => e.codatr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codatrval)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CodEmpNavigation).WithMany(p => p.BL_NOVEDADES_SUSPENSION)
                .HasForeignKey(d => d.CodEmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_NOVEDADES_SUSPENSION_Codemp");

            entity.HasOne(d => d.IdLiqTipoNavigation).WithMany(p => p.BL_NOVEDADES_SUSPENSION)
                .HasForeignKey(d => d.IdLiqTipo)
                .HasConstraintName("FK_BL_NOVEDADES_SUSPENSION_BL_LIQUIDACIONESTIPOS");

            entity.HasOne(d => d.IdSucesoNavigation).WithMany(p => p.BL_NOVEDADES_SUSPENSION)
                .HasForeignKey(d => d.IdSuceso)
                .HasConstraintName("FK_BL_NOVEDADES_SUSPENSION_BL_SUCESOS");
        });

        modelBuilder.Entity<BL_NovedadesPedidos>(entity =>
        {
            entity.HasKey(e => e.IdOcurrenciaPedido)
                .HasName("PK_BL_NOVEDADESPEDIDOS")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.Estado).HasDefaultValue((short)0);
            entity.Property(e => e.FecDesde).HasColumnType("datetime");
            entity.Property(e => e.FecHasta).HasColumnType("datetime");
            entity.Property(e => e.FecSolicitud).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesAdmin)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesManager)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_NovedadesPedidos_Detalle>(entity =>
        {
            entity.HasKey(e => new { e.IdOcurrenciaPedido, e.EstadoAnterior, e.EstadoNuevo })
                .HasName("PK_BL_NOVEDADESPEDIDOS_DETALLE")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.FecOcurrencia).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCambioDeEstado)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasOne(d => d.IdLegajoCambioDeEstadoNavigation).WithMany(p => p.BL_NovedadesPedidos_Detalle)
                .HasForeignKey(d => d.IdLegajoCambioDeEstado)
                .HasConstraintName("FK_BL_NOVEDADESPEDIDOS_DETALLE_LEGAJOS");

            entity.HasOne(d => d.IdOcurrenciaPedidoNavigation).WithMany(p => p.BL_NovedadesPedidos_Detalle)
                .HasForeignKey(d => d.IdOcurrenciaPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_NOVEDADESPEDIDOS_DETALLE_PEDIDOS");
        });

        modelBuilder.Entity<BL_OBJETOSMAESTROS>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FecAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.IdObjeto).ValueGeneratedOnAdd();
            entity.Property(e => e.NombreTabla)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_OBJETOSTRANSACCION>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdTransaccion, e.FecAlta }, "BL_OBJETOSTRANSACCION_FECALTA").HasFillFactor(90);

            entity.Property(e => e.FecAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdTransaccion).ValueGeneratedOnAdd();
            entity.Property(e => e.NombreTabla)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_PARAMETROS>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.PARAMETRO, e.CodEmp }, "IX_BL_PARAMETROS2")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.CodEmp).HasDefaultValue((short)1);
            entity.Property(e => e.DATEVALOR).HasColumnType("datetime");
            entity.Property(e => e.PARAMETRO)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RegistrarVarSiEs0).HasDefaultValue(false);
            entity.Property(e => e.STRVALOR)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.TIPOVALOR)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("S")
                .IsFixedLength();
        });

        modelBuilder.Entity<BL_PARENTESCOS>(entity =>
        {
            entity.HasKey(e => e.IdParentesco)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.CodParentesco, "UN_BL_PARENTESCOS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdParentesco).ValueGeneratedNever();
            entity.Property(e => e.CodParentesco)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("O")
                .IsFixedLength();
        });

        modelBuilder.Entity<BL_PERSONALEVENTUAL>(entity =>
        {
            entity.HasKey(e => new { e.idPersonalEventual, e.CUIL }).HasFillFactor(90);

            entity.Property(e => e.CUIL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Apellido)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Domicilio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FecEgreso).HasColumnType("smalldatetime");
            entity.Property(e => e.FecIngreso).HasColumnType("smalldatetime");
            entity.Property(e => e.FecNacimiento).HasColumnType("smalldatetime");
            entity.Property(e => e.Localidad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.Tarea)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_PERSONAS>(entity =>
        {
            entity.HasKey(e => e.IdPersona)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("CTRL_PERSONAS"));

            entity.HasIndex(e => e.Codigo, "UN_BL_PERSONAS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdPersona).ValueGeneratedNever();
            entity.Property(e => e.Apellido)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoCasada)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.CUIL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodDoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Codigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DocNro)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCalle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCodPos)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioDepto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioLoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioNro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioPiso)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.EmailPersonal)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FecNacimiento).HasColumnType("smalldatetime");
            entity.Property(e => e.Foto).HasColumnType("image");
            entity.Property(e => e.HabilitadoAutogestion).HasDefaultValue(true);
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.PublicarRecibos).HasDefaultValue(true);
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CodDocNavigation).WithMany(p => p.BL_PERSONAS)
                .HasForeignKey(d => d.CodDoc)
                .HasConstraintName("FK_BL_PERSONAS_TIPODOC");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.BL_PERSONAS)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK_BL_PERSONAS_BL_ESTADOSCIVILES");

            entity.HasOne(d => d.IdNacionalidadNavigation).WithMany(p => p.BL_PERSONAS)
                .HasForeignKey(d => d.IdNacionalidad)
                .HasConstraintName("FK_BL_PERSONAS_BL_NACIONALIDADES");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.BL_PERSONAS)
                .HasForeignKey(d => d.IdProvincia)
                .HasConstraintName("FK_BL_PERSONAS_BL_PROVINCIAS");
        });

        modelBuilder.Entity<BL_PERSONASATRIBUTOS>(entity =>
        {
            entity.HasKey(e => new { e.IdPersona, e.CodAtr }).HasFillFactor(90);

            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.CodAtrNavigation).WithMany(p => p.BL_PERSONASATRIBUTOS)
                .HasForeignKey(d => d.CodAtr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_PERSONASATRIBUTOS_ATRIBUTOS");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.BL_PERSONASATRIBUTOS)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_PERSONASATRIBUTOS_BL_PERSONAS");

            entity.HasOne(d => d.ATRIBUTOSVAL).WithMany(p => p.BL_PERSONASATRIBUTOS)
                .HasForeignKey(d => new { d.CodAtr, d.CodAtrVal })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_PERSONASATRIBUTOS_ATRIBUTOSVAL");
        });

        modelBuilder.Entity<BL_PROVINCIAS>(entity =>
        {
            entity.HasKey(e => e.IdProvincia)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.NroProvincia, "UN_BL_PROVINCIAS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdProvincia).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NroProvincia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<BL_RECIBOS>(entity =>
        {
            entity.HasKey(e => new { e.IdLiquidacion, e.IdLegajo })
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.IdTransaccion, e.IdLiquidacion, e.IdLegajo }, "BL_RECIBOS_IDTRANSACCION").HasFillFactor(90);

            entity.HasIndex(e => new { e.IdLiquidacion, e.IdLegajo }, "BL_RECIBOS_idlegajo")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.PDF_Nombre, "IX_BL_RECIBOS_PDF_Nombre");

            entity.Property(e => e.ArchivoGananciasUpload).HasColumnType("datetime");
            entity.Property(e => e.FTPUpLoad).HasColumnType("datetime");
            entity.Property(e => e.Firmado_Fecha).HasColumnType("datetime");
            entity.Property(e => e.MD5)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NroCuenta)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Observacion)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.PDF_Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PDF_RutaFTP)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.PDF_RutaLOC)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.PagoFecha).HasColumnType("smalldatetime");
            entity.Property(e => e.PagoLugar)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReciboTexto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.UltDepFecha).HasColumnType("smalldatetime");
            entity.Property(e => e.UltDepMesCorresp).HasColumnType("smalldatetime");
            entity.Property(e => e.ValorMTS).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Visualizado).HasColumnType("datetime");
            entity.Property(e => e.ultDepBanco)
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.HasOne(d => d.IdLegajoNavigation).WithMany(p => p.BL_RECIBOS)
                .HasForeignKey(d => d.IdLegajo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_RECIBOS_BL_LEGAJOS");

            entity.HasOne(d => d.IdLiquidacionNavigation).WithMany(p => p.BL_RECIBOS)
                .HasForeignKey(d => d.IdLiquidacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_RECIBOS_BL_LIQUIDACIONES");

            entity.HasOne(d => d.IdReparticionNavigation).WithMany(p => p.BL_RECIBOS)
                .HasForeignKey(d => d.IdReparticion)
                .HasConstraintName("FK_IdReparticion");
        });

        modelBuilder.Entity<BL_RECIBOS_ACCIONESWEB>(entity =>
        {
            entity.HasKey(e => e.IdAccion);

            entity.Property(e => e.IdAccion).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_RECIBOS_AUDITORIAWEB>(entity =>
        {
            entity.HasKey(e => e.IdSecuencia);

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Firmado_Fecha).HasColumnType("datetime");
            entity.Property(e => e.Observacion)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_RECIBOS_PRORRATEOS>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdLiquidacion, e.IdLegajo }, "BL_RECIBOS_PRORRATEOS_IDLIQ_IDLEG").HasFillFactor(90);

            entity.HasIndex(e => new { e.Mes, e.IdLegajo, e.Importe }, "IX1_BL_RECIBOS_PRORRATEOS").HasFillFactor(90);

            entity.HasIndex(e => new { e.Mes, e.IdLegajo, e.ImporteGan }, "IX2_BL_RECIBOS_PRORRATEOS").HasFillFactor(90);

            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ImporteGan).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Mes).HasColumnType("datetime");
        });

        modelBuilder.Entity<BL_RECIBOS_PRORRATEOS_SIMULACION>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ImporteGan).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Mes).HasColumnType("datetime");
        });

        modelBuilder.Entity<BL_RECIBOS_SIMULACION>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ArchivoGananciasUpload).HasColumnType("datetime");
            entity.Property(e => e.FTPUpLoad).HasColumnType("datetime");
            entity.Property(e => e.Firmado_Fecha).HasColumnType("datetime");
            entity.Property(e => e.MD5)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NroCuenta)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Observacion)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.PDF_Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PDF_RutaFTP)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.PDF_RutaLOC)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.PagoFecha).HasColumnType("smalldatetime");
            entity.Property(e => e.PagoLugar)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReciboTexto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.UltDepFecha).HasColumnType("smalldatetime");
            entity.Property(e => e.UltDepMesCorresp).HasColumnType("smalldatetime");
            entity.Property(e => e.ValorMTS).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Visualizado).HasColumnType("datetime");
            entity.Property(e => e.ultDepBanco)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_REPARTICIONES>(entity =>
        {
            entity.HasKey(e => e.IdReparticion)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.CodReparticion, "UN_BL_REPARTICIONES")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdReparticion).ValueGeneratedNever();
            entity.Property(e => e.CodReparticion)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Contacto)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Denominacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCalle)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCodPos)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioDepto)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioLoc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioNro)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioPiso)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.EMail)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.NroInscrEmpresa)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaginaWeb)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<BL_REPSASOCIADAS>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdLegajo, e.IdReparticion }, "UN_BL_REPSASOCIADAS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.CBU)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FecAlta).HasColumnType("smalldatetime");
            entity.Property(e => e.NroInscrLegajo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdLegajoNavigation).WithMany()
                .HasForeignKey(d => d.IdLegajo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_REPSASOCIADAS_BL_LEGAJOS");

            entity.HasOne(d => d.IdReparticionNavigation).WithMany()
                .HasForeignKey(d => d.IdReparticion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_REPSASOCIADAS_BL_REPARTICIONES");
        });

        modelBuilder.Entity<BL_SECURITY_GRUPOS>(entity =>
        {
            entity.HasKey(e => e.IdGrupo).HasFillFactor(90);

            entity.HasIndex(e => e.Nombre, "IX1_BL_SECURITY_GRUPOS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_SECURITY_GRUPOSUSUARIOS>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.IdGrupo }).HasFillFactor(90);

            entity.Property(e => e.NOMBREGRUPO)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_SECURITY_PERMISOS>(entity =>
        {
            entity.HasKey(e => new { e.IdTipo, e.IdPermiso }).HasFillFactor(90);

            entity.Property(e => e.Permiso)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.BL_SECURITY_PERMISOS)
                .HasForeignKey(d => d.IdTipo)
                .HasConstraintName("FK_BL_SECURITY_PERMISOS_BL_SECURITY_TIPOS");
        });

        modelBuilder.Entity<BL_SECURITY_SETEO>(entity =>
        {
            entity.HasKey(e => e.IdSeteo).HasFillFactor(90);

            entity.HasIndex(e => new { e.IdTipo, e.IdPermiso, e.IdUsuario, e.IdGrupo, e.IdLegajo, e.CodAtr, e.CodAtrVal, e.CenPrefi, e.CodCen, e.CodEmp }, "IX_BL_SECURITY_SETEO").HasFillFactor(90);

            entity.Property(e => e.CenPrefi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodCen)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodVariable)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.BL_SECURITY_SETEO)
                .HasForeignKey(d => d.IdGrupo)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BL_SECURITY_SETEO_BL_SECURITY_GRUPOS");

            entity.HasOne(d => d.IdLegajoNavigation).WithMany(p => p.BL_SECURITY_SETEO)
                .HasForeignKey(d => d.IdLegajo)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BL_SECURITY_SETEO_BL_LEGAJOS");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.BL_SECURITY_SETEO)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BL_SECURITY_SETEO_BL_SECURITY_USUARIOS");

            entity.HasOne(d => d.CENTROSAP).WithMany(p => p.BL_SECURITY_SETEO)
                .HasForeignKey(d => new { d.CenPrefi, d.CodCen })
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BL_SECURITY_SETEO_CENTROSAP");

            entity.HasOne(d => d.ATRIBUTOSVAL).WithMany(p => p.BL_SECURITY_SETEO)
                .HasForeignKey(d => new { d.CodAtr, d.CodAtrVal })
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BL_SECURITY_SETEO_ATRIBUTOSVAL");

            entity.HasOne(d => d.BL_SECURITY_PERMISOS).WithMany(p => p.BL_SECURITY_SETEO)
                .HasForeignKey(d => new { d.IdTipo, d.IdPermiso })
                .HasConstraintName("FK_BL_SECURITY_SETEO_BL_SECURITY_PERMISOS");
        });

        modelBuilder.Entity<BL_SECURITY_TIPOS>(entity =>
        {
            entity.HasKey(e => e.IdTipo).HasFillFactor(90);

            entity.Property(e => e.IdTipo).ValueGeneratedNever();
            entity.Property(e => e.DetalleTipo)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_SECURITY_USUARIOS>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasFillFactor(90);

            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_SITUACIONESREVISTA>(entity =>
        {
            entity.HasKey(e => e.IdSituacion)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.NroSituacion, "UN_BL_SITUACIONESREVISTA")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdSituacion).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.IncluirSIJP).HasDefaultValue((byte)1);
        });

        modelBuilder.Entity<BL_SUCESOS>(entity =>
        {
            entity.HasKey(e => e.IdSuceso)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.CodSuceso, "UN_BL_SUCESOS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdSuceso).ValueGeneratedNever();
            entity.Property(e => e.AliasAutogestion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CodAtrDH)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodSuceso)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DiasHabiles).HasDefaultValue(false);
            entity.Property(e => e.HabilitadoAutogestion).HasDefaultValue(true);
            entity.Property(e => e.HabilitadoSoloManager).HasDefaultValue(false);
            entity.Property(e => e.TipoTope)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .IsFixedLength();
            entity.Property(e => e.codAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IDClaseSucesoNavigation).WithMany(p => p.BL_SUCESOS)
                .HasForeignKey(d => d.IDClaseSuceso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_SUCESOS_BL_SUCESOSCLASES");

            entity.HasOne(d => d.IdDocTextoNavigation).WithMany(p => p.BL_SUCESOS)
                .HasForeignKey(d => d.IdDocTexto)
                .HasConstraintName("FK_BL_SUCESOS_BL_DOCSTEXTO");

            entity.HasOne(d => d.codAtrNavigation).WithMany(p => p.BL_SUCESOS)
                .HasForeignKey(d => d.codAtr)
                .HasConstraintName("FK_BL_SUCESOS_ATRIBUTOS");
        });

        modelBuilder.Entity<BL_SUCESOSCLASES>(entity =>
        {
            entity.HasKey(e => e.IdClaseSuceso)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.Tratamiento, "BL_SUCESOSCLASES_TRATAMIENTO").HasFillFactor(90);

            entity.HasIndex(e => e.CodClaseSuceso, "UN_BL_SUCESOSCLASES")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdClaseSuceso).ValueGeneratedNever();
            entity.Property(e => e.CodClaseSuceso)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.FechaAfectada)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoTope)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .IsFixedLength();
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.codAtrNavigation).WithMany(p => p.BL_SUCESOSCLASES)
                .HasForeignKey(d => d.codAtr)
                .HasConstraintName("FK_BL_SUCESOSCLASES_ATRIBUTOS");
        });

        modelBuilder.Entity<BL_SUCESOSCLASESTOPES>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdClaseSuceso, e.codAtrVal }, "BL_SUCESOSCLASESTOPES_ID")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.TopeAnio).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TopeMes).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TopeNovedad).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.codAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdClaseSucesoNavigation).WithMany()
                .HasForeignKey(d => d.IdClaseSuceso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_SUCESOSCLASESTOPES_BL_SUCESOSCLASES");
        });

        modelBuilder.Entity<BL_SUCESOSDIASHABILES>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.UsaDiasHabiles).HasDefaultValue(1);

            entity.HasOne(d => d.IdSucesoNavigation).WithMany()
                .HasForeignKey(d => d.IdSuceso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_SUCESOSDIASHABILES_BL_SUCESOS");
        });

        modelBuilder.Entity<BL_SUCESOSTOPES>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BL_SUCESOSTOPES");

            entity.Property(e => e.TopeAnio).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TopeMes).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TopeNovedad).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.codAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<BL_SUCESOSTOPES1>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TopeAnio).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TopeMes).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TopeNovedad).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.codAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdSucesoNavigation).WithMany()
                .HasForeignKey(d => d.IdSuceso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_SUCESOSTOPES1_BL_SUCESOS");
        });

        modelBuilder.Entity<BL_SUCESOSTOPES2>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TopeAnio).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TopeMes).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TopeNovedad).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.codAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdSucesoNavigation).WithMany()
                .HasForeignKey(d => d.IdSuceso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_SUCESOSTOPES2_BL_SUCESOS");
        });

        modelBuilder.Entity<BL_TAREAS>(entity =>
        {
            entity.HasKey(e => e.IdTarea)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.IdTarea).ValueGeneratedNever();
            entity.Property(e => e.Comentario).HasColumnType("text");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.FinPeriodo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Frecuencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength();
            entity.Property(e => e.Semana)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Semanadia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoMensual)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuOrigen)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
            entity.Property(e => e.generado).HasDefaultValue(false);
        });

        modelBuilder.Entity<BL_TAREASUSU>(entity =>
        {
            entity.HasKey(e => new { e.IdTarea, e.UsuDestino })
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.UsuDestino)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.IdTareaNavigation).WithMany(p => p.BL_TAREASUSU)
                .HasForeignKey(d => d.IdTarea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_TAREASUSU_BL_TAREAS");
        });

        modelBuilder.Entity<BL_TEMPVALORESREGISTRADOS>(entity =>
        {
            entity.HasKey(e => new { e.IdLegajo, e.MesLiq, e.CodLiq }).HasFillFactor(90);

            entity.Property(e => e.MesLiq)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodLiq)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DescAtr1)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DescAtr2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DescAtr3)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DescAtr4)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DescAtr5)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.ValorAcum1).HasColumnType("money");
            entity.Property(e => e.ValorAcum2).HasColumnType("money");
            entity.Property(e => e.ValorAcum3).HasColumnType("money");
            entity.Property(e => e.ValorAcum4).HasColumnType("money");
            entity.Property(e => e.ValorAcum5).HasColumnType("money");
            entity.Property(e => e.ValorAtr1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ValorAtr2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ValorAtr3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ValorAtr4)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ValorAtr5)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ValorVar1).HasColumnType("money");
            entity.Property(e => e.ValorVar2).HasColumnType("money");
            entity.Property(e => e.ValorVar3).HasColumnType("money");
            entity.Property(e => e.ValorVar4).HasColumnType("money");
            entity.Property(e => e.ValorVar5).HasColumnType("money");
        });

        modelBuilder.Entity<BL_TIPOSEMPLEADORES>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Codigo2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.VigenciaDesde).HasColumnType("datetime");
            entity.Property(e => e.VigenciaHasta).HasColumnType("datetime");
        });

        modelBuilder.Entity<BL_TOTALIZADORES>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Id, "UN_BL_TOTALIZADORES")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_USUEMPRESAS>(entity =>
        {
            entity.HasKey(e => new { e.USERNAME, e.CODEMP }).HasFillFactor(90);

            entity.Property(e => e.USERNAME)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CODEMPNavigation).WithMany(p => p.BL_USUEMPRESAS)
                .HasForeignKey(d => d.CODEMP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_USUEMPRESAS_EMPRESAS");
        });

        modelBuilder.Entity<BL_VARIABLESDEFINIBLES>(entity =>
        {
            entity.HasKey(e => e.IdVariable)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("CTRL_VARIABLESDEFINIBLES"));

            entity.HasIndex(e => e.CodVariable, "UN_BL_VARIABLESDEFINIBLES")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdVariable).ValueGeneratedNever();
            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodVariable)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoAcum)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoTope)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<BL_VARIABLESGANANCIAS>(entity =>
        {
            entity.HasKey(e => e.IdVariable).HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("CTRL_VARIABLESGANANCIAS"));

            entity.HasIndex(e => e.CodVariable, "UN_BL_VARIABLESGANANCIAS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdVariable).ValueGeneratedNever();
            entity.Property(e => e.CodVariable)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoAcum)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<BL_VARIABLESPLANILLAGAN>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Campo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Excepcion).IsUnicode(false);
            entity.Property(e => e.Longitud).HasDefaultValue(15);
            entity.Property(e => e.RegistroDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistroTipo)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Version)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_VARIABLESPREDEFINIDAS>(entity =>
        {
            entity.HasKey(e => e.CODIGO)
                .HasName("PK_BL_VARIABLESPREDEFINIDAS_CODIGO")
                .HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("CTRL_VARIABLESPREDEFINIDAS"));

            entity.Property(e => e.CODIGO)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.COMMANDTEXT)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IDVARIABLE).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BL_VARIABLESTOPES>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TopeAnio).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TopeMes).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TopeNovedad).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<BL_VARIABLESVALS>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdLiquidacion, e.IdLegajo, e.CodVariable }, "BL_VARIABLESVALS_IDLEGAJO")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.CodVariable)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.IdLiquidacionNavigation).WithMany()
                .HasForeignKey(d => d.IdLiquidacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BL_VARIABLESVALS_BL_LIQUIDACIONES");
        });

        modelBuilder.Entity<BL_VARIABLESVALS_SIMULACION>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodVariable)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<BL_VARIABLESVISOR4TA>(entity =>
        {
            entity.HasKey(e => e.Id4ta);

            entity.Property(e => e.Id4ta).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Codigo4ta)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion4ta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Grupo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_VARIABLES_F1359>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Campo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Excepcion).IsUnicode(false);
            entity.Property(e => e.Longitud).HasDefaultValue(15);
            entity.Property(e => e.RegistroDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistroTipo)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Version)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_VARIABLES_F2122>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Campo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Excepcion).IsUnicode(false);
            entity.Property(e => e.Longitud).HasDefaultValue(15);
            entity.Property(e => e.RegistroDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistroTipo)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Version)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BL_VISTAS>(entity =>
        {
            entity.HasKey(e => e.IdVista)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.CodEmp, e.CodVista }, "UN_BL_VISTAS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.IdVista).ValueGeneratedNever();
            entity.Property(e => e.CodEmp).HasDefaultValue((short)1);
            entity.Property(e => e.CodVista)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.CodEmpNavigation).WithMany(p => p.BL_VISTAS)
                .HasForeignKey(d => d.CodEmp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bl_vistas_Codemp");
        });

        modelBuilder.Entity<BL_ZONAS>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Zona, "UN_BL_ZONAS")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.CodZona)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PorReduccion).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<BRCOLEXCLUIDAS>(entity =>
        {
            entity.HasKey(e => new { e.CodBrowse, e.SubCodigo }).HasFillFactor(90);

            entity.Property(e => e.CamposExcluidos)
                .HasMaxLength(7000)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<BRCONFIG>(entity =>
        {
            entity.HasKey(e => new { e.USUARIO, e.CODPROG, e.CODBROWSE }).HasFillFactor(90);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("ACTU_BROWSE");
                    tb.HasTrigger("NUE_BROWSE");
                });

            entity.Property(e => e.USUARIO)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CODBROWSENavigation).WithMany(p => p.BRCONFIG)
                .HasForeignKey(d => d.CODBROWSE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRCONFIG_BRTABLAS");

            entity.HasOne(d => d.CODPROGNavigation).WithMany(p => p.BRCONFIG)
                .HasForeignKey(d => d.CODPROG)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRCONFIG_PROGRAMAS");
        });

        modelBuilder.Entity<BRCONFIGDET>(entity =>
        {
            entity.HasKey(e => new { e.USUARIO, e.CODPROG, e.CODBROWSE, e.COLUMNA }).HasFillFactor(90);

            entity.Property(e => e.USUARIO)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.COLUMNA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ANCHO).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.CODATR)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FILTRO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TIPORDEN)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CODBROWSENavigation).WithMany(p => p.BRCONFIGDET)
                .HasForeignKey(d => d.CODBROWSE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRCONFIGDET_BRTABLAS");

            entity.HasOne(d => d.BRTABLASCOLS).WithMany(p => p.BRCONFIGDET)
                .HasForeignKey(d => new { d.CODBROWSE, d.COLUMNA })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRCONFIGDET_BRCOLUMNAS");

            entity.HasOne(d => d.BRCONFIG).WithMany(p => p.BRCONFIGDET)
                .HasForeignKey(d => new { d.USUARIO, d.CODPROG, d.CODBROWSE })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRCONFIGDET_BRCONFIG");
        });

        modelBuilder.Entity<BRTABLAS>(entity =>
        {
            entity.HasKey(e => e.CODBROWSE).HasFillFactor(90);

            entity.Property(e => e.CODBROWSE).ValueGeneratedNever();
            entity.Property(e => e.ALIAS)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ATRIBUTOS)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FILTRO)
                .HasMaxLength(750)
                .IsUnicode(false);
            entity.Property(e => e.FILTROHAVING)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FROMTABLAS)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NOMBRE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TITULOVENTANA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.tiempoespera).HasDefaultValue((short)30);
        });

        modelBuilder.Entity<BRTABLASCOLS>(entity =>
        {
            entity.HasKey(e => new { e.CODBROWSE, e.COLUMNA })
                .HasName("PK_BRCOLUMNAS")
                .HasFillFactor(90);

            entity.Property(e => e.COLUMNA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ANCHO).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TIPO)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TITULO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VALORNOELEGIBLE)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.CODBROWSENavigation).WithMany(p => p.BRTABLASCOLS)
                .HasForeignKey(d => d.CODBROWSE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRCOLUMNAS_BRTABLAS");
        });

        modelBuilder.Entity<BRTABLASCOLSCASE>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TEXTCASE)
                .HasMaxLength(600)
                .IsUnicode(false);

            entity.HasOne(d => d.CODBROWSENavigation).WithMany()
                .HasForeignKey(d => d.CODBROWSE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TABLASCOLSCASE_BRTABLAS");
        });

        modelBuilder.Entity<BRTABLASJOINS>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TEXTJOIN)
                .HasMaxLength(900)
                .IsUnicode(false);

            entity.HasOne(d => d.CODBROWSENavigation).WithMany()
                .HasForeignKey(d => d.CODBROWSE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TABLASJOINS_BRTABLAS");
        });

        modelBuilder.Entity<Bl_AutogestionCambiosPer>(entity =>
        {
            entity.HasKey(e => e.IdPersona)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.IdPersona).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.FecOcurrencia).HasColumnType("datetime");
        });

        modelBuilder.Entity<Bl_AutogestionCambiosPerPendientes>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Email)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.FecOcurrencia).HasColumnType("datetime");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CATEGORIAS>(entity =>
        {
            entity.HasKey(e => new { e.IdConvenio, e.CodCat }).HasFillFactor(90);

            entity.Property(e => e.CodCat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdCategoria).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<CENTROSAP>(entity =>
        {
            entity.HasKey(e => new { e.CENPREFI, e.CODCEN }).HasFillFactor(90);

            entity.Property(e => e.CENPREFI)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CODCEN)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdCentroAp).ValueGeneratedOnAdd();
            entity.Property(e => e.NOMBRE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<CONTROLESEXP>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CONTROLESEXP");

            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Formula)
                .HasMaxLength(7000)
                .IsUnicode(false);
            entity.Property(e => e.ID)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Id_FecPago)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Origen)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TipoFmt)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CUENTAS>(entity =>
        {
            entity.HasKey(e => e.CODCUE).HasFillFactor(90);

            entity.Property(e => e.CODCUE).ValueGeneratedNever();
            entity.Property(e => e.CODAGR)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CODIGO)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("*")
                .IsFixedLength();
            entity.Property(e => e.DESDE).HasColumnType("datetime");
            entity.Property(e => e.HASTA).HasColumnType("datetime");
            entity.Property(e => e.NOMBRE)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SDOHAB)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SUBCUENTAS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TIPOCUENTA)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CODTABNavigation).WithMany(p => p.CUENTAS)
                .HasForeignKey(d => d.CODTAB)
                .HasConstraintName("FK_CUENTAS_TABLAS");
        });

        modelBuilder.Entity<CentrosAppSync>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CENPREFI)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CODCEN)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NOMBRE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Consulta1Variables4ta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Consulta1Variables4ta");

            entity.Property(e => e.Codigo4ta)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion4ta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaYHora).HasColumnType("datetime");
            entity.Property(e => e.MesPago).HasColumnType("smalldatetime");
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<Consulta2Variables4ta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Consulta2Variables4ta");

            entity.Property(e => e.Codigo4ta)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion4ta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<ConsultaVariables4ta_Mes>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ConsultaVariables4ta_Mes");

            entity.Property(e => e.FechaYHora).HasColumnType("datetime");
            entity.Property(e => e.MesPago).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<CuentasSync>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CODAGR)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CODIGO)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DESDE).HasColumnType("datetime");
            entity.Property(e => e.HASTA).HasColumnType("datetime");
            entity.Property(e => e.NOMBRE)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SDOHAB)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SUBCUENTAS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TIPOCUENTA)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<EMPRESAS>(entity =>
        {
            entity.HasKey(e => e.CODEMP).HasFillFactor(90);

            entity.Property(e => e.CODEMP).ValueGeneratedNever();
            entity.Property(e => e.ACTIVIDAD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CAJAPREV)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CAJAPREVNRO)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CODDOC)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CODPAIS)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CODPOS)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CODPRV)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CONTACT1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CONTACT2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DOMICILIO)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DOMICILIO2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FAX)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FEC_VALORIZACION).HasColumnType("datetime");
            entity.Property(e => e.FMTRET1)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FMTRET2)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FMTRETGAN)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FMTRETIVA)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FMTRETSUSS)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IMPRESORAIVA)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IMPRESORAR1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IMPRESORAR2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IMPRESORARG)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IMPRESORARS)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IVA)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LOCALIDAD)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MINIMOGAN).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.MINIMOIVA).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.MINIMOSUSS).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.NOMBRE)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NOMBRERET1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NOMBRERET2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NRODOC1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NROINSCRRNIC)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PERCMINGAN).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.PERCMINIVA).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TELEFONO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TIMESTAMP)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.TIPOCOPIARG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("S")
                .IsFixedLength();
            entity.Property(e => e.TIPOCOPIARI)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("S")
                .IsFixedLength();
            entity.Property(e => e.TIPOSIJP).HasDefaultValue((byte)1);
            entity.Property(e => e.codctabcoaux)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.fec_fin_val).HasColumnType("datetime");
            entity.Property(e => e.logo).HasColumnType("image");
        });

        modelBuilder.Entity<EmpresasBASCS>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<EmpresasRelacion>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<Evidencias>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Evidencias");

            entity.Property(e => e.TipoEvidencia)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FX_ScriptExec>(entity =>
        {
            entity.HasKey(e => e.IdScript)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.IdScript)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dependencias)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdScripts)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<FX_ScriptTransactions>(entity =>
        {
            entity.HasKey(e => e.IdScript).HasFillFactor(90);

            entity.Property(e => e.IdScript)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dependencias)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.IdScripts)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.RecuperarBackup).HasDefaultValue((byte)1);
        });

        modelBuilder.Entity<FX_SysVersion>(entity =>
        {
            entity.HasKey(e => e.IdSistema).HasFillFactor(90);

            entity.Property(e => e.IdSistema)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProyectoVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<FmtControles>(entity =>
        {
            entity.HasKey(e => new { e.CodProg, e.Control })
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.Control)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FmtControlesAlias>(entity =>
        {
            entity.HasKey(e => new { e.CodProg, e.CodFmt, e.Control, e.Alias }).HasFillFactor(90);

            entity.Property(e => e.CodFmt)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Control)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FmtControlesExp>(entity =>
        {
            entity.HasKey(e => new { e.TipoFmt, e.Columna }).HasFillFactor(90);

            entity.Property(e => e.TipoFmt)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Columna)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ColumnaXFecPago)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TIPO)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Titulo)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.TipoFmtNavigation).WithMany(p => p.FmtControlesExp)
                .HasForeignKey(d => d.TipoFmt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FmtControlesExp_FmtTiposExp");
        });

        modelBuilder.Entity<FmtControlesSel>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Columna)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.TipoFmt)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.txtGroupBy)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.txtJoin)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.txtWhere)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<FmtJoinsExp>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TextJoin)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TipoFmt)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.HasOne(d => d.TipoFmtNavigation).WithMany()
                .HasForeignKey(d => d.TipoFmt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FmtJoinsExp_FmtTiposExp");
        });

        modelBuilder.Entity<FmtLineas>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Control)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.codFmt)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.codFmtNavigation).WithMany()
                .HasForeignKey(d => d.codFmt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FmtLineas_Formatos");

            entity.HasOne(d => d.FmtControles).WithMany()
                .HasForeignKey(d => new { d.CodProg, d.Control })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FmtLineas_FmtControles");
        });

        modelBuilder.Entity<FmtLineasExp>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FmtNroFecha)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Operacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Origen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("C")
                .IsFixedLength();
            entity.Property(e => e.Texto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codFmt)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.codFmtNavigation).WithMany()
                .HasForeignKey(d => d.codFmt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FmtLineasExp_FormatosExp");
        });

        modelBuilder.Entity<FmtTiposExp>(entity =>
        {
            entity.HasKey(e => e.TipoFmt)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.TipoFmt)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FromTablas)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TiempoEspera).HasDefaultValue((short)30);
        });

        modelBuilder.Entity<Formatos>(entity =>
        {
            entity.HasKey(e => e.codFmt)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.codFmt)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FormatosExp>(entity =>
        {
            entity.HasKey(e => e.codFmt)
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.codFmt)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.QuitarBlancos).HasDefaultValue(true);
            entity.Property(e => e.SaltoLinea).HasDefaultValue(true);
            entity.Property(e => e.TipoFmt)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.HasOne(d => d.TipoFmtNavigation).WithMany(p => p.FormatosExp)
                .HasForeignKey(d => d.TipoFmt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormatosExp_FmtTiposExp");
        });

        modelBuilder.Entity<GETATRIBUTOS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GETATRIBUTOS");

            entity.Property(e => e.codatr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.prefiatr)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<LegajosPermitidosAgenda>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<MODELIN>(entity =>
        {
            entity.HasKey(e => new { e.CODMOD, e.SECUENCIA })
                .HasName("PK_MODELIN_1__20")
                .HasFillFactor(90);

            entity.Property(e => e.CAMPO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CONTENIDO).HasColumnType("text");
            entity.Property(e => e.CONTENIDO2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CODMODNavigation).WithMany(p => p.MODELIN)
                .HasForeignKey(d => d.CODMOD)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MODELIN_MODELOS");
        });

        modelBuilder.Entity<MODELOS>(entity =>
        {
            entity.HasKey(e => e.CODMOD).HasFillFactor(90);

            entity.Property(e => e.CODMOD).ValueGeneratedNever();
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<MyTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MyTable", "adminlaboro");

            entity.Property(e => e.Actividad)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Adherentes)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.AdiOS)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Adicionales)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AporteAdiOS)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AporteVolunt)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AsiFam)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CUIL)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CantDiasTrab)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CantHorasTrab)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CantHsExtras)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CapitalRecomp)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CoberturaSVO)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CodSiniestro)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ConcNoRem)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CondLaboral)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Conyuge)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DiaSitRev1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DiaSitRev2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DiaSitRev3)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Hijos)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.HorasExtras)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MarcaReduccion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Maternidad)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NroInscrLegajo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.NroSituacion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PorTareaDif)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Porapoadi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Premios)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RectifRem)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemDec78805)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemImp)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemImp2)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemImp3)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemImp4)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemImp5)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemImp6)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemImp7)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemImp9)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RemTot)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SAC)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SitRev1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SitRev2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SitRev3)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SueldoAdic)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoEmpresa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoOpera)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoRegimen)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TrabConven)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Vacaciones)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Zona)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ZonaDesfavorable)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.excedenteaos)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.excedenteass)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.modcontratacion)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NOVEDADES_NORMALIZADAS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NOVEDADES_NORMALIZADAS");

            entity.Property(e => e.CodAtrval)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FecDesde).HasColumnType("datetime");
            entity.Property(e => e.FecHasta).HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<NOVEDADES_NORMALIZADAS2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NOVEDADES_NORMALIZADAS2");

            entity.Property(e => e.CodAtrval)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FecDesde).HasColumnType("datetime");
            entity.Property(e => e.FecHasta).HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<NOVEDADES_NORMALIZADAS3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NOVEDADES_NORMALIZADAS3");

            entity.Property(e => e.CodAtrval)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FecDesde).HasColumnType("datetime");
            entity.Property(e => e.FecHasta).HasColumnType("datetime");
            entity.Property(e => e.FechaAfectada)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<NUMEROS>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<NovedadesLegajos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NovedadesLegajos");

            entity.Property(e => e.Cod_Suceso)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Cod.Suceso");
            entity.Property(e => e.Cod_Variable)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Cod.Variable");
            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaReg).HasColumnType("datetime");
            entity.Property(e => e.Nro_Concepto).HasColumnName("Nro.Concepto");
            entity.Property(e => e.Suceso)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Variable)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VtoMesAnioDesde).HasColumnType("smalldatetime");
            entity.Property(e => e.centroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.centroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codatr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codatrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.codliq)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.legajo)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ORG_CarpetaCarpeta>(entity =>
        {
            entity.HasKey(e => new { e.IdCarpeta, e.IdCarpetaHijo, e.IdEstructura });

            entity.HasOne(d => d.IdCarpetaNavigation).WithMany(p => p.ORG_CarpetaCarpetaIdCarpetaNavigation)
                .HasForeignKey(d => d.IdCarpeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_CarpetaCarpeta_ORG_Carpetas");

            entity.HasOne(d => d.IdCarpetaHijoNavigation).WithMany(p => p.ORG_CarpetaCarpetaIdCarpetaHijoNavigation)
                .HasForeignKey(d => d.IdCarpetaHijo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_CarpetaCarpeta_ORG_Carpetas1");

            entity.HasOne(d => d.IdEstructuraNavigation).WithMany(p => p.ORG_CarpetaCarpeta)
                .HasForeignKey(d => d.IdEstructura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_CarpetaCarpeta_ORG_Estructuras");
        });

        modelBuilder.Entity<ORG_CarpetaPersona>(entity =>
        {
            entity.HasKey(e => new { e.IdCarpeta, e.IdPersonaHijo, e.IdEstructura });

            entity.HasOne(d => d.IdCarpetaNavigation).WithMany(p => p.ORG_CarpetaPersona)
                .HasForeignKey(d => d.IdCarpeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_CarpetaPersona_ORG_Carpetas");

            entity.HasOne(d => d.IdEstructuraNavigation).WithMany(p => p.ORG_CarpetaPersona)
                .HasForeignKey(d => d.IdEstructura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_CarpetaPersona_ORG_Estructuras");

            entity.HasOne(d => d.IdPersonaHijoNavigation).WithMany(p => p.ORG_CarpetaPersona)
                .HasForeignKey(d => d.IdPersonaHijo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_CarpetaPersona_BL_PERSONAS");
        });

        modelBuilder.Entity<ORG_CarpetaPuesto>(entity =>
        {
            entity.HasKey(e => new { e.IdCarpeta, e.IdPuestoHijo, e.IdEstructura });

            entity.HasOne(d => d.IdCarpetaNavigation).WithMany(p => p.ORG_CarpetaPuesto)
                .HasForeignKey(d => d.IdCarpeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_CarpetaPuesto_ORG_Carpetas");

            entity.HasOne(d => d.IdEstructuraNavigation).WithMany(p => p.ORG_CarpetaPuesto)
                .HasForeignKey(d => d.IdEstructura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_CarpetaPuesto_ORG_Estructuras");

            entity.HasOne(d => d.IdPuestoHijoNavigation).WithMany(p => p.ORG_CarpetaPuesto)
                .HasForeignKey(d => d.IdPuestoHijo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_CarpetaPuesto_ORG_Puestos");
        });

        modelBuilder.Entity<ORG_Carpetas>(entity =>
        {
            entity.HasKey(e => e.IdCarpeta);

            entity.Property(e => e.IdCarpeta).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ORG_Estructuras>(entity =>
        {
            entity.HasKey(e => e.IdEstructura);

            entity.Property(e => e.IdRaiz).HasDefaultValue(0);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdOrganigramaNavigation).WithMany(p => p.ORG_Estructuras)
                .HasForeignKey(d => d.IdOrganigrama)
                .HasConstraintName("FK_ORG_Estructuras_ORG_Principal");
        });

        modelBuilder.Entity<ORG_Principal>(entity =>
        {
            entity.HasKey(e => e.IdOrganigrama);

            entity.Property(e => e.CodEmp).HasMaxLength(10);
        });

        modelBuilder.Entity<ORG_PuestoPersona>(entity =>
        {
            entity.HasKey(e => new { e.IdPuesto, e.IdPersonaHijo, e.IdEstructura });

            entity.HasOne(d => d.IdEstructuraNavigation).WithMany(p => p.ORG_PuestoPersona)
                .HasForeignKey(d => d.IdEstructura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_PuestoPersona_ORG_Estructuras");

            entity.HasOne(d => d.IdPersonaHijoNavigation).WithMany(p => p.ORG_PuestoPersona)
                .HasForeignKey(d => d.IdPersonaHijo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_PuestoPersona_BL_PERSONAS");

            entity.HasOne(d => d.IdPuestoNavigation).WithMany(p => p.ORG_PuestoPersona)
                .HasForeignKey(d => d.IdPuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_PuestoPersona_ORG_Puestos");
        });

        modelBuilder.Entity<ORG_PuestoPuesto>(entity =>
        {
            entity.HasKey(e => new { e.IdPuesto, e.IdPuestoHijo, e.IdEstructura });

            entity.HasOne(d => d.IdEstructuraNavigation).WithMany(p => p.ORG_PuestoPuesto)
                .HasForeignKey(d => d.IdEstructura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_PuestoPuesto_ORG_Estructuras");

            entity.HasOne(d => d.IdPuestoNavigation).WithMany(p => p.ORG_PuestoPuestoIdPuestoNavigation)
                .HasForeignKey(d => d.IdPuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_PuestoPuesto_ORG_Puestos");

            entity.HasOne(d => d.IdPuestoHijoNavigation).WithMany(p => p.ORG_PuestoPuestoIdPuestoHijoNavigation)
                .HasForeignKey(d => d.IdPuestoHijo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORG_PuestoPuesto_ORG_Puestos1");
        });

        modelBuilder.Entity<ORG_Puestos>(entity =>
        {
            entity.HasKey(e => e.IdPuesto);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("ORG_Puestos_Delete");
                    tb.HasTrigger("ORG_Puestos_Insert");
                    tb.HasTrigger("ORG_Puestos_Update");
                });

            entity.Property(e => e.IdPuesto).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PARAMETROS>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb => tb.HasTrigger("CTRL_BONIFICACIONES"));

            entity.Property(e => e.AMORTIZACION)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ATRCLIOCASIONAL)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ATRPROCASIONAL)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AUXILIAR)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CAJPREFI)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CENTROA)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CENTROB)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CODBON)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CODCPTCOM)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CODCPTVEN)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CODLIS)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CONDIOCASIONAL)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DELIMTALLES)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DESCMONEDA)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DESPAGMAS).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DESPAGMENOS).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DESRECMAS).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DESRECMENOS).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.FCFORMATO)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FECHAVERSION).HasColumnType("datetime");
            entity.Property(e => e.FONT)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.INF_CPP).HasDefaultValue((byte)1);
            entity.Property(e => e.INF_CPPCIERRE).HasDefaultValue((byte)1);
            entity.Property(e => e.INF_FIFO).HasDefaultValue((byte)1);
            entity.Property(e => e.INF_LIFO).HasDefaultValue((byte)1);
            entity.Property(e => e.LISTA1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LISTA2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LISTA3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LISTA4)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LISTAOCASIONAL)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MINNCPRONTOPAGO).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.MINNDRECARGO).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.MONEDA)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NCPRONTOPAGO)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NDRECARGO)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PESO)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PREFOCASIONAL)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.STOCKPED)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.STOCKPED2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TASAIVA).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TASAIVANOI).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TIPOVALUACION)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TITDOBLE)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TRATOCASIONAL)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VALATRCLIOCASIONAL)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VALATRPROCASIONAL)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VERSION)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VOLUMEN)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXBONIFICACION1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXBONIFICACION2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXBONIFMAX1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXBONIFMAX2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXCODCTABCOAUX)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXFMTRET1)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXFMTRET2)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXFMTRETGAN)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXFMTRETIVA)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXFMTRETSUSS)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXIMPRESORAIVA)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXIMPRESORAR1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXIMPRESORAR2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXIMPRESORARG)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXIMPRESORARS)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXIVA)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXMINIMOGAN).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.XXXMINIMOIVA).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.XXXMINIMOSUSS).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.XXXNOMBRERET1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXNOMBRERET2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.XXXPERCMINIVA).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.decimales).HasDefaultValue((byte)1);
            entity.Property(e => e.valprogramada).HasDefaultValue((short)60);
            entity.Property(e => e.valsistema).HasDefaultValue((short)60);
            entity.Property(e => e.xxxBMP)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxEMPRESA)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxLOGO).HasColumnType("image");
            entity.Property(e => e.xxxautorizaped)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxautorizaped2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxautorizaped3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxcodatr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxcodatr2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxcodatr3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxcodatrval)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxcodatrval2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxcodatrval3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxcoditmnc)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxcoditmnd)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxcreditoped)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.xxxmaxsinaut).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.xxxmaxsinautnc).HasColumnType("decimal(18, 5)");

            entity.HasOne(d => d.CODCUE2Navigation).WithMany()
                .HasForeignKey(d => d.CODCUE2)
                .HasConstraintName("FK_PARAMETROS_CUENTAS2");

            entity.HasOne(d => d.CODCUECOMNavigation).WithMany()
                .HasForeignKey(d => d.CODCUECOM)
                .HasConstraintName("FK_PARAMETROS_CUENTAS3");

            entity.HasOne(d => d.CODCUEIINavigation).WithMany()
                .HasForeignKey(d => d.CODCUEII)
                .HasConstraintName("FK_PARAMETROS_CUENTAS4");

            entity.HasOne(d => d.CODCUEVENNavigation).WithMany()
                .HasForeignKey(d => d.CODCUEVEN)
                .HasConstraintName("FK_PARAMETROS_CUENTAS5");

            entity.HasOne(d => d.CODTAB2Navigation).WithMany()
                .HasForeignKey(d => d.CODTAB2)
                .HasConstraintName("FK_PARAMETROS_TABLAS");

            entity.HasOne(d => d.CODTABVAL2Navigation).WithMany()
                .HasForeignKey(d => d.CODTABVAL2)
                .HasConstraintName("FK_PARAMETROS_TABLAS2");
        });

        modelBuilder.Entity<PERMISOS>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PROGRAMAEXT)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Sistema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.USUARIO)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.CODPROGNavigation).WithMany()
                .HasForeignKey(d => d.CODPROG)
                .HasConstraintName("FK_PERMISOS_PROGRAMAS");
        });

        modelBuilder.Entity<PERMISOSABM>(entity =>
        {
            entity.HasKey(e => new { e.USUARIO, e.CODPROG }).HasFillFactor(90);

            entity.Property(e => e.USUARIO)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CONSULTA).HasDefaultValue((byte)0);
        });

        modelBuilder.Entity<PERMISOSCAMPOS>(entity =>
        {
            entity.HasKey(e => new { e.USUARIO, e.CODPROG, e.CAMPO }).HasFillFactor(90);

            entity.Property(e => e.USUARIO)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CAMPO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CONSULTA).HasDefaultValue((byte)0);
            entity.Property(e => e.CONTENIDO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<PROGRAMAS>(entity =>
        {
            entity.HasKey(e => e.CODPROG).HasFillFactor(90);

            entity.Property(e => e.CODPROG).ValueGeneratedNever();
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HTMLHELP)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PROGRAMA)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PROGRAMAWEB)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<PROGRAMAS_IMPORTACION>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PROGRAMAS_IMPORTACION");

            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PROGRAMA)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PROGRAMAWEB)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<PersonasPermitidasAgenda>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<ProvinciasSync>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.NOMBRE)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NROPROVINCIA)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Prueba>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cadena)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Currency_dec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Currency_mil)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Number_dec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Number_mil)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<RHV_Cancelaciones>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RHV_Cancelaciones");

            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<RHV_CapacitacionesDePlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RHV_CapacitacionesDePlan");

            entity.Property(e => e.AsistentesPersonas).IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoCap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCap)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RHV_CapacitacionesProveedores>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RHV_CapacitacionesProveedores");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RHV_EvaluacionesDePlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RHV_EvaluacionesDePlan");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoEva)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionEva)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EvaluadosPersonas).IsUnicode(false);
        });

        modelBuilder.Entity<RHV_Evidencias>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RHV_Evidencias");
        });

        modelBuilder.Entity<RHV_EvidenciasHabilidades>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RHV_EvidenciasHabilidades");

            entity.Property(e => e.FecOcurrencia).HasColumnType("datetime");
            entity.Property(e => e.FecVencimiento).HasColumnType("datetime");
        });

        modelBuilder.Entity<RHV_EvidenciasHabilidadesAdHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RHV_EvidenciasHabilidadesAdHoc");

            entity.Property(e => e.FecOcurrencia).HasColumnType("datetime");
            entity.Property(e => e.FecVencimiento).HasColumnType("datetime");
        });

        modelBuilder.Entity<RHV_Planes>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RHV_Planes");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RHV_PlanesPersonas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RHV_PlanesPersonas");

            entity.Property(e => e.AsistentesPersonas).IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RHV_VistaEvidencias>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RHV_VistaEvidencias");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RHV_Vista_EvidenciasFaltantes_Documentos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RHV_Vista_EvidenciasFaltantes_Documentos");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RHV_Vista_EvidenciasFaltantes_Evaluaciones>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RHV_Vista_EvidenciasFaltantes_Evaluaciones");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RH_AlternativasCapacitaciones>(entity =>
        {
            entity.HasKey(e => new { e.IdAlternativa, e.IdHabilidad, e.IdCapacitacion }).IsClustered(false);

            entity.HasOne(d => d.IdCapacitacionNavigation).WithMany(p => p.RH_AlternativasCapacitaciones)
                .HasForeignKey(d => d.IdCapacitacion)
                .HasConstraintName("FK_RH_AlternativasCapacitaciones_Capacitaciones");

            entity.HasOne(d => d.IdHabilidadNavigation).WithMany(p => p.RH_AlternativasCapacitaciones)
                .HasForeignKey(d => d.IdHabilidad)
                .HasConstraintName("FK_RH_AlternativasCapacitaciones_Habilidades");
        });

        modelBuilder.Entity<RH_AlternativasDocumentos>(entity =>
        {
            entity.HasKey(e => new { e.IdAlternativa, e.IdHabilidad, e.IdDocumento });

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.RH_AlternativasDocumentos)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("FK_RH_AlternativasDocumentos_Documentos");

            entity.HasOne(d => d.IdHabilidadNavigation).WithMany(p => p.RH_AlternativasDocumentos)
                .HasForeignKey(d => d.IdHabilidad)
                .HasConstraintName("FK_RH_AlternativasDocumentos_Habilidades");
        });

        modelBuilder.Entity<RH_AlternativasEvaluaciones>(entity =>
        {
            entity.HasKey(e => new { e.IdAlternativa, e.IdHabilidad, e.IdEvaluacion });

            entity.HasOne(d => d.IdEvaluacionNavigation).WithMany(p => p.RH_AlternativasEvaluaciones)
                .HasForeignKey(d => d.IdEvaluacion)
                .HasConstraintName("FK_RH_AlternativasEvaluaciones_Evaluaciones");

            entity.HasOne(d => d.IdHabilidadNavigation).WithMany(p => p.RH_AlternativasEvaluaciones)
                .HasForeignKey(d => d.IdHabilidad)
                .HasConstraintName("FK_RH_AlternativasEvaluaciones_Habilidades");
        });

        modelBuilder.Entity<RH_Capacitaciones>(entity =>
        {
            entity.HasKey(e => e.IdCapacitacion).IsClustered(false);

            entity.HasIndex(e => new { e.CodEmp, e.Codigo }, "UN_RH_Capacitaciones").IsUnique();

            entity.Property(e => e.IdCapacitacion).ValueGeneratedNever();
            entity.Property(e => e.CantidadEtapas).HasDefaultValue((short)1);
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TipoEvidencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<RH_CapacitacionesAtributos>(entity =>
        {
            entity.HasKey(e => new { e.IdCapacitacion, e.CodAtr });

            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.CodAtrNavigation).WithMany(p => p.RH_CapacitacionesAtributos)
                .HasForeignKey(d => d.CodAtr)
                .HasConstraintName("FK_RH_CapacitacionesAtributos_Atributos");

            entity.HasOne(d => d.IdCapacitacionNavigation).WithMany(p => p.RH_CapacitacionesAtributos)
                .HasForeignKey(d => d.IdCapacitacion)
                .HasConstraintName("FK_RH_CapacitacionesAtributos_Capacitaciones");

            entity.HasOne(d => d.ATRIBUTOSVAL).WithMany(p => p.RH_CapacitacionesAtributos)
                .HasForeignKey(d => new { d.CodAtr, d.CodAtrVal })
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_CapacitacionesAtributos_AtributosVal");
        });

        modelBuilder.Entity<RH_CapacitacionesEvaluaciones>(entity =>
        {
            entity.HasKey(e => new { e.IdCapacitacion, e.IdEvaluacion });

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdCapacitacionNavigation).WithMany(p => p.RH_CapacitacionesEvaluaciones)
                .HasForeignKey(d => d.IdCapacitacion)
                .HasConstraintName("FK_RH_CapacitacionesEvaluaciones_Capacitaciones");

            entity.HasOne(d => d.IdEvaluacionNavigation).WithMany(p => p.RH_CapacitacionesEvaluaciones)
                .HasForeignKey(d => d.IdEvaluacion)
                .HasConstraintName("FK_RH_CapacitacionesEvaluaciones_Evaluaciones");
        });

        modelBuilder.Entity<RH_CapacitacionesProveedores>(entity =>
        {
            entity.HasKey(e => new { e.IdCapacitacion, e.IdProveedor });

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdCapacitacionNavigation).WithMany(p => p.RH_CapacitacionesProveedores)
                .HasForeignKey(d => d.IdCapacitacion)
                .HasConstraintName("FK_RH_CapacitacionesProveedores_Capacitaciones");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.RH_CapacitacionesProveedores)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK_RH_CapacitacionesProveedores_Proveedores");
        });

        modelBuilder.Entity<RH_Documentos>(entity =>
        {
            entity.HasKey(e => e.IdDocumento).IsClustered(false);

            entity.HasIndex(e => new { e.CodEmp, e.Codigo }, "UN_RH_Documentos").IsUnique();

            entity.Property(e => e.IdDocumento).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PalabrasClaves)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<RH_ElementosAtributos>(entity =>
        {
            entity.HasKey(e => new { e.IdElemento, e.CodAtr });

            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtrVal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.CodAtrNavigation).WithMany(p => p.RH_ElementosAtributos)
                .HasForeignKey(d => d.CodAtr)
                .HasConstraintName("FK_RH_ElementosAtributos_Atributos");

            entity.HasOne(d => d.IdElementoNavigation).WithMany(p => p.RH_ElementosAtributos)
                .HasForeignKey(d => d.IdElemento)
                .HasConstraintName("FK_RH_ElementosAtributos_Elementos");

            entity.HasOne(d => d.ATRIBUTOSVAL).WithMany(p => p.RH_ElementosAtributos)
                .HasForeignKey(d => new { d.CodAtr, d.CodAtrVal })
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_ElementosAtributos_AtributosVal");
        });

        modelBuilder.Entity<RH_ElementosCapacitaciones>(entity =>
        {
            entity.HasKey(e => new { e.IdElemento, e.IdCapacitacion });

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdCapacitacionNavigation).WithMany(p => p.RH_ElementosCapacitaciones)
                .HasForeignKey(d => d.IdCapacitacion)
                .HasConstraintName("FK_RH_ElementosCapacitaciones_Capacitaciones");

            entity.HasOne(d => d.IdElementoNavigation).WithMany(p => p.RH_ElementosCapacitaciones)
                .HasForeignKey(d => d.IdElemento)
                .HasConstraintName("FK_RH_ElementosCapacitaciones_Elementos");
        });

        modelBuilder.Entity<RH_ElementosDeTrabajo>(entity =>
        {
            entity.HasKey(e => e.IdElemento);

            entity.HasIndex(e => new { e.CodEmp, e.Codigo }, "UN_RH_ElementosDeTrabajo").IsUnique();

            entity.Property(e => e.IdElemento).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DescDocAsociado)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DocAsociado).HasColumnType("image");

            entity.HasOne(d => d.IdObservacionesNavigation).WithMany(p => p.RH_ElementosDeTrabajo)
                .HasForeignKey(d => d.IdObservaciones)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_ElementosDeTrabajo_RTF_Textos");
        });

        modelBuilder.Entity<RH_ElementosMeses>(entity =>
        {
            entity.HasKey(e => new { e.IdElemento, e.Mes });
        });

        modelBuilder.Entity<RH_ElementosPuestos>(entity =>
        {
            entity.HasKey(e => new { e.IdElemento, e.IdPuesto });

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdElementoNavigation).WithMany(p => p.RH_ElementosPuestos)
                .HasForeignKey(d => d.IdElemento)
                .HasConstraintName("FK_RH_ElementosPuestos_Elementos");

            entity.HasOne(d => d.IdPuestoNavigation).WithMany(p => p.RH_ElementosPuestos)
                .HasForeignKey(d => d.IdPuesto)
                .HasConstraintName("FK_RH_ElementosPuestos_Puestos");
        });

        modelBuilder.Entity<RH_Escalas>(entity =>
        {
            entity.HasKey(e => e.IdEscala).IsClustered(false);

            entity.HasIndex(e => e.Codigo, "UN_RH_Escalas").IsUnique();

            entity.Property(e => e.IdEscala).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RH_Escalas_Valores>(entity =>
        {
            entity.HasKey(e => e.IdEscalaValor).IsClustered(false);

            entity.HasIndex(e => new { e.IdEscalaValor, e.Codigo }, "UN_RH_Escalas_Valores").IsUnique();

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.IdEscalaNavigation).WithMany(p => p.RH_Escalas_Valores)
                .HasForeignKey(d => d.IdEscala)
                .HasConstraintName("FK_RH_Escalas_Valores_RH_Escalas");
        });

        modelBuilder.Entity<RH_EsquemasDePlanes>(entity =>
        {
            entity.HasKey(e => e.IdEsquema).IsClustered(false);

            entity.HasIndex(e => e.Codigo, "UN_RH_EsquemasDePlanes").IsUnique();

            entity.Property(e => e.IdEsquema).ValueGeneratedNever();
            entity.Property(e => e.AvisoAgenda).HasDefaultValue(true);
            entity.Property(e => e.AvisoMail).HasDefaultValue(true);
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DiasAnticipacion).HasDefaultValue((short)0);
            entity.Property(e => e.Frecuencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MesInicial)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RH_EstadosDeCapacitacion>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK_RH_EstadosCap");

            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RH_Evaluaciones>(entity =>
        {
            entity.HasKey(e => e.IdEvaluacion).IsClustered(false);

            entity.HasIndex(e => new { e.CodEmp, e.Codigo }, "UN_RH_Evaluaciones").IsUnique();

            entity.Property(e => e.IdEvaluacion).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEscalaNavigation).WithMany(p => p.RH_Evaluaciones)
                .HasForeignKey(d => d.IdEscala)
                .HasConstraintName("FK_RH_Evaluaciones_Escalas");
        });

        modelBuilder.Entity<RH_EvaluacionesFormularios>(entity =>
        {
            entity.HasKey(e => new { e.IdEvaluacion, e.IdFormulario });

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdEvaluacionNavigation).WithMany(p => p.RH_EvaluacionesFormularios)
                .HasForeignKey(d => d.IdEvaluacion)
                .HasConstraintName("FK_RH_EvaluacionesFormularios_Evaluaciones");

            entity.HasOne(d => d.IdFormularioNavigation).WithMany(p => p.RH_EvaluacionesFormularios)
                .HasForeignKey(d => d.IdFormulario)
                .HasConstraintName("FK_RH_EvaluacionesFormularios_Formularios");
        });

        modelBuilder.Entity<RH_Factores>(entity =>
        {
            entity.HasKey(e => e.IdFactor).IsClustered(false);

            entity.HasIndex(e => e.Codigo, "UN_RH_Factores").IsUnique();

            entity.Property(e => e.IdFactor).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RH_Formularios>(entity =>
        {
            entity.HasKey(e => e.IdFormulario).IsClustered(false);

            entity.HasIndex(e => new { e.CodEmp, e.Codigo }, "UN_RH_Formularios").IsUnique();

            entity.Property(e => e.IdFormulario).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RH_FormulariosFactores>(entity =>
        {
            entity.HasKey(e => new { e.IdFormulario, e.IdFactor });

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdFactorNavigation).WithMany(p => p.RH_FormulariosFactores)
                .HasForeignKey(d => d.IdFactor)
                .HasConstraintName("FK_RH_FormulariosFactores_Factores");

            entity.HasOne(d => d.IdFormularioNavigation).WithMany(p => p.RH_FormulariosFactores)
                .HasForeignKey(d => d.IdFormulario)
                .HasConstraintName("FK_RH_FormulariosFactores_Formularios");
        });

        modelBuilder.Entity<RH_Formularios_Detalle>(entity =>
        {
            entity.HasKey(e => new { e.IdFormulario, e.IdFormularioDetalle })
                .HasName("PK_Formularios_Detalle")
                .IsClustered(false);

            entity.Property(e => e.Evaluadores).IsUnicode(false);
            entity.Property(e => e.Evaluados).IsUnicode(false);
            entity.Property(e => e.Responsables).IsUnicode(false);

            entity.HasOne(d => d.IdFormularioNavigation).WithMany(p => p.RH_Formularios_Detalle)
                .HasForeignKey(d => d.IdFormulario)
                .HasConstraintName("FK_RH_Formularios_Detalle_Formularios");
        });

        modelBuilder.Entity<RH_Habilidades>(entity =>
        {
            entity.HasKey(e => e.IdHabilidad).IsClustered(false);

            entity.HasIndex(e => new { e.CodEmp, e.Codigo }, "UN_RH_Habilidades").IsUnique();

            entity.Property(e => e.IdHabilidad).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RH_HabilidadesAdHoc>(entity =>
        {
            entity.HasKey(e => new { e.IdEvidencia, e.IdHabilidad }).HasName("PK_RH_RH_HabilidadesAdHoc");

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdHabilidadNavigation).WithMany(p => p.RH_HabilidadesAdHoc)
                .HasForeignKey(d => d.IdHabilidad)
                .HasConstraintName("FK_RH_HabilidadesAdHoc_Habilidades");
        });

        modelBuilder.Entity<RH_HabilidadesAlternativas>(entity =>
        {
            entity.HasKey(e => new { e.IdHabilidad, e.IdAlternativa });

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.IdHabilidadNavigation).WithMany(p => p.RH_HabilidadesAlternativas)
                .HasForeignKey(d => d.IdHabilidad)
                .HasConstraintName("FK_RH_HabilidadesAlternativas_Habilidades");
        });

        modelBuilder.Entity<RH_Novedades>(entity =>
        {
            entity.HasKey(e => e.IdOcurrencia).IsClustered(false);

            entity.Property(e => e.IdOcurrencia).ValueGeneratedNever();
            entity.Property(e => e.DescDocAsociado)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Documento).HasColumnType("image");
            entity.Property(e => e.FecOcurrencia).HasColumnType("datetime");
            entity.Property(e => e.FechaReg).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<RH_NovedadesCancelaciones>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdObservacionesNavigation).WithMany()
                .HasForeignKey(d => d.IdObservaciones)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesCancelaciones_Observaciones");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany()
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RH_NovedadesCancelaciones_Personas");
        });

        modelBuilder.Entity<RH_NovedadesCancelaciones_Anexo>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<RH_NovedadesCapacitaciones>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FecDesde).HasColumnType("datetime");
            entity.Property(e => e.FecHasta).HasColumnType("datetime");
            entity.Property(e => e.IdProveedor).HasDefaultValue(0);
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdCapacitacionNavigation).WithMany()
                .HasForeignKey(d => d.IdCapacitacion)
                .HasConstraintName("FK_RH_NovedadesCapacitaciones_Capacitaciones");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany()
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK_RH_NovedadesCapacitaciones_Personas");

            entity.HasOne(d => d.IdPlanCapNavigation).WithMany()
                .HasForeignKey(d => d.IdPlanCap)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesCapacitaciones_PlanesCapacitaciones");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany()
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesCapacitaciones_Proveedores");
        });

        modelBuilder.Entity<RH_NovedadesDocumentos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DescDocAsociado)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DocAsociado).HasColumnType("image");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Vencimiento).HasColumnType("datetime");

            entity.HasOne(d => d.IdCapacitacionNavigation).WithMany()
                .HasForeignKey(d => d.IdCapacitacion)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesDocumentos_Capacitaciones");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany()
                .HasForeignKey(d => d.IdDocumento)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesDocumentos_Documentos");

            entity.HasOne(d => d.IdObservacionesNavigation).WithMany()
                .HasForeignKey(d => d.IdObservaciones)
                .HasConstraintName("FK_RH_NovedadesDocumentos_Observaciones");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany()
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK_RH_NovedadesDocumentos_Personas");
        });

        modelBuilder.Entity<RH_NovedadesElementos>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb =>
                {
                    tb.HasTrigger("TGR_NOVSELEMENTOSDELETE");
                    tb.HasTrigger("TGR_NOVSELEMENTOSINSERT");
                });

            entity.Property(e => e.Cantidad).HasDefaultValue(1);
            entity.Property(e => e.FecDevolucion).HasColumnType("datetime");
            entity.Property(e => e.FecReposicion).HasColumnType("datetime");
            entity.Property(e => e.IdDetalle).ValueGeneratedOnAdd();
            entity.Property(e => e.Identificador)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<RH_NovedadesEvaluaciones>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DescDocAsociado)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DocAsociado).HasColumnType("image");
            entity.Property(e => e.FecEvaluacion).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Vencimiento).HasColumnType("datetime");

            entity.HasOne(d => d.IdCapacitacionNavigation).WithMany()
                .HasForeignKey(d => d.IdCapacitacion)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesEvaluaciones_Capacitaciones");

            entity.HasOne(d => d.IdComentariosEvaluadoNavigation).WithMany()
                .HasForeignKey(d => d.IdComentariosEvaluado)
                .HasConstraintName("FK_RH_NovedadesEvaluaciones_ComentariosEvaluado");

            entity.HasOne(d => d.IdComentariosEvaluadorNavigation).WithMany()
                .HasForeignKey(d => d.IdComentariosEvaluador)
                .HasConstraintName("FK_RH_NovedadesEvaluaciones_ComentariosEvaluador");

            entity.HasOne(d => d.IdConclusionNavigation).WithMany()
                .HasForeignKey(d => d.IdConclusion)
                .HasConstraintName("FK_RH_NovedadesEvaluaciones_Conclusiones");

            entity.HasOne(d => d.IdEvaluacionNavigation).WithMany()
                .HasForeignKey(d => d.IdEvaluacion)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesEvaluaciones_Evaluaciones");

            entity.HasOne(d => d.IdEvaluadorNavigation).WithMany()
                .HasForeignKey(d => d.IdEvaluador)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesEvaluaciones_Evaluadores");

            entity.HasOne(d => d.IdFormularioNavigation).WithMany()
                .HasForeignKey(d => d.IdFormulario)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesEvaluaciones_Formularios");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany()
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK_RH_NovedadesEvaluaciones_Personas");
        });

        modelBuilder.Entity<RH_NovedadesEvaluaciones_AnexoFactores>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdFactorNavigation).WithMany()
                .HasForeignKey(d => d.IdFactor)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesEvaluaciones_AnexoFactores_Factores");

            entity.HasOne(d => d.IdFormularioNavigation).WithMany()
                .HasForeignKey(d => d.IdFormulario)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesEvaluaciones_AnexoFactores_Formularios");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany()
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK_RH_NovedadesEvaluaciones_AnexoFactores_Personas");
        });

        modelBuilder.Entity<RH_NovedadesExcepciones>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdHabilidadNavigation).WithMany()
                .HasForeignKey(d => d.IdHabilidad)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesExcepciones_Habilidades");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany()
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK_RH_NovedadesExcepciones_Personas");
        });

        modelBuilder.Entity<RH_NovedadesHabilidades>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdHabilidadNavigation).WithMany()
                .HasForeignKey(d => d.IdHabilidad)
                .HasConstraintName("FK_RH_NovedadesHabilidades_Habilidades");
        });

        modelBuilder.Entity<RH_NovedadesPersonas>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FecFinCapacitacion).HasColumnType("datetime");
            entity.Property(e => e.FecInicioCapacitacion).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdObservacionesNavigation).WithMany()
                .HasForeignKey(d => d.IdObservaciones)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_NovedadesPersonas_Observaciones");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany()
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK_RH_NovedadesPersonas_Personas");
        });

        modelBuilder.Entity<RH_NovedadesPuestos>(entity =>
        {
            entity.HasKey(e => e.IdNovPuesto);

            entity.HasOne(d => d.IdOcurrenciaNavigation).WithMany(p => p.RH_NovedadesPuestos)
                .HasForeignKey(d => d.IdOcurrencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RH_NovedadesPuestos_RH_Novedades");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.RH_NovedadesPuestos)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RH_NovedadesPuestos_Personas");

            entity.HasOne(d => d.IdPuestoNavigation).WithMany(p => p.RH_NovedadesPuestos)
                .HasForeignKey(d => d.IdPuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RH_NovedadesPuestos_RH_PuestosHistorico");

            entity.HasOne(d => d.IdSucesoNavigation).WithMany(p => p.RH_NovedadesPuestos)
                .HasForeignKey(d => d.IdSuceso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RH_NovedadesPuestos_BL_SUCESOS");
        });

        modelBuilder.Entity<RH_NovedadesTipos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Grupo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<RH_Personas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RH_Personas");

            entity.Property(e => e.Apellido)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoCasada)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.CUIL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DNI)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCalle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCodPos)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioDepto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioLoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioNro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioPiso)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioProv)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.EmailPersonal)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FecNacimiento).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaEgreso).HasColumnType("datetime");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.Foto).HasColumnType("image");
            entity.Property(e => e.Legajo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.Puesto)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RH_Personas2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RH_Personas2");

            entity.Property(e => e.Codigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FecNacimiento).HasColumnType("smalldatetime");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Puesto).IsUnicode(false);
        });

        modelBuilder.Entity<RH_PlanesCapacitaciones>(entity =>
        {
            entity.HasKey(e => new { e.IdPlanCap, e.IdResponsable, e.IdCapacitacion }).IsClustered(false);

            entity.Property(e => e.Asistentes).IsUnicode(false);
            entity.Property(e => e.AsistentesPersonas).IsUnicode(false);
            entity.Property(e => e.CostoEst).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FecEstimada).HasColumnType("datetime");

            entity.HasOne(d => d.IdCapacitacionNavigation).WithMany(p => p.RH_PlanesCapacitaciones)
                .HasForeignKey(d => d.IdCapacitacion)
                .HasConstraintName("FK_RH_PlanesCapacitaciones_Capacitaciones");

            entity.HasOne(d => d.RH_PlanesResponsables).WithMany(p => p.RH_PlanesCapacitaciones)
                .HasForeignKey(d => new { d.IdPlanCap, d.IdResponsable })
                .HasConstraintName("FK_RH_PlanesCapacitaciones_PlanesResponsables");
        });

        modelBuilder.Entity<RH_PlanesDeCapacitacion>(entity =>
        {
            entity.HasKey(e => e.IdPlanCap)
                .HasName("PK_RH_Planes")
                .IsClustered(false);

            entity.HasIndex(e => new { e.CodEmp, e.Codigo }, "UN_RH_Planes").IsUnique();

            entity.Property(e => e.IdPlanCap).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FecCierre).HasColumnType("datetime");
            entity.Property(e => e.FecInicioEjec).HasColumnType("datetime");
            entity.Property(e => e.FecInicioPlanif).HasColumnType("datetime");
            entity.Property(e => e.Responsables).IsUnicode(false);
            entity.Property(e => e.ResponsablesPersonas).IsUnicode(false);
        });

        modelBuilder.Entity<RH_PlanesDeEvaluacion>(entity =>
        {
            entity.HasKey(e => e.IdPlanEva).IsClustered(false);

            entity.HasIndex(e => new { e.CodEmp, e.Codigo }, "UN_RH_PlanesDeEvaluacion").IsUnique();

            entity.Property(e => e.IdPlanEva).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FecCierre).HasColumnType("datetime");
            entity.Property(e => e.FecInicioEjec).HasColumnType("datetime");
            entity.Property(e => e.FecInicioPlanif).HasColumnType("datetime");
            entity.Property(e => e.Responsables).IsUnicode(false);
            entity.Property(e => e.ResponsablesPersonas).IsUnicode(false);

            entity.HasOne(d => d.IdEsquemaNavigation).WithMany(p => p.RH_PlanesDeEvaluacion)
                .HasForeignKey(d => d.IdEsquema)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RH_PlanesDeEvaluacion_Esquema");
        });

        modelBuilder.Entity<RH_PlanesEvaluaciones>(entity =>
        {
            entity.HasKey(e => new { e.IdPlanEva, e.IdEvaluacion }).IsClustered(false);

            entity.Property(e => e.FecEntrega).HasColumnType("datetime");

            entity.HasOne(d => d.IdEvaluacionNavigation).WithMany(p => p.RH_PlanesEvaluaciones)
                .HasForeignKey(d => d.IdEvaluacion)
                .HasConstraintName("FK_RH_PlanesEvaluaciones_Evaluaciones");
        });

        modelBuilder.Entity<RH_PlanesFormularios>(entity =>
        {
            entity.HasKey(e => new { e.IdPlanEva, e.IdEvaluacion, e.IdFormulario, e.IdFormularioDetalle }).IsClustered(false);

            entity.Property(e => e.IdFormularioDetalle).HasDefaultValue(1);
            entity.Property(e => e.EvaluadoresPersonas).IsUnicode(false);
            entity.Property(e => e.EvaluadosPersonas).IsUnicode(false);
            entity.Property(e => e.ResponsablesPersonas).IsUnicode(false);

            entity.HasOne(d => d.IdEvaluacionNavigation).WithMany(p => p.RH_PlanesFormularios)
                .HasForeignKey(d => d.IdEvaluacion)
                .HasConstraintName("FK_RH_PlanesFormularios_Evaluaciones");

            entity.HasOne(d => d.IdFormularioNavigation).WithMany(p => p.RH_PlanesFormularios)
                .HasForeignKey(d => d.IdFormulario)
                .HasConstraintName("FK_RH_PlanesFormularios_Formularios");
        });

        modelBuilder.Entity<RH_PlanesProveedores>(entity =>
        {
            entity.HasKey(e => new { e.IdPlanCap, e.IdResponsable, e.IdCapacitacion, e.IdProveedor }).IsClustered(false);

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdCapacitacionNavigation).WithMany(p => p.RH_PlanesProveedores)
                .HasForeignKey(d => d.IdCapacitacion)
                .HasConstraintName("FK_RH_PlanesProveedores_Capacitaciones");

            entity.HasOne(d => d.RH_PlanesResponsables).WithMany(p => p.RH_PlanesProveedores)
                .HasForeignKey(d => new { d.IdPlanCap, d.IdResponsable })
                .HasConstraintName("FK_RH_PlanesProveedores_PlanesResponsables");
        });

        modelBuilder.Entity<RH_PlanesResponsables>(entity =>
        {
            entity.HasKey(e => new { e.IdPlanCap, e.IdResponsable }).IsClustered(false);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Responsables).IsUnicode(false);
            entity.Property(e => e.ResponsablesPersonas).IsUnicode(false);

            entity.HasOne(d => d.IdPlanCapNavigation).WithMany(p => p.RH_PlanesResponsables)
                .HasForeignKey(d => d.IdPlanCap)
                .HasConstraintName("FK_RH_PlanesResponsables_Planes");
        });

        modelBuilder.Entity<RH_Proveedores>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).IsClustered(false);

            entity.HasIndex(e => e.Codigo, "UN_RH_Proveedores").IsUnique();

            entity.Property(e => e.IdProveedor).ValueGeneratedNever();
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Contacto)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RH_Puestos>(entity =>
        {
            entity.HasKey(e => e.IdPuesto).IsClustered(false);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("RH_Puestos_Delete");
                    tb.HasTrigger("RH_Puestos_Insert");
                    tb.HasTrigger("RH_Puestos_Update");
                });

            entity.HasIndex(e => new { e.Nombre, e.IdPuestoSup, e.IdVista }, "UN_RH_Puestos").IsUnique();

            entity.Property(e => e.IdPuesto).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RH_PuestosHabilidades>(entity =>
        {
            entity.HasKey(e => new { e.IdPuesto, e.IdHabilidad });

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.IdHabilidadNavigation).WithMany(p => p.RH_PuestosHabilidades)
                .HasForeignKey(d => d.IdHabilidad)
                .HasConstraintName("FK_RH_PuestosHabilidades_Habilidades");

            entity.HasOne(d => d.IdPuestoNavigation).WithMany(p => p.RH_PuestosHabilidades)
                .HasForeignKey(d => d.IdPuesto)
                .HasConstraintName("FK_RH_PuestosHabilidades_Puestos");
        });

        modelBuilder.Entity<RH_PuestosHistorico>(entity =>
        {
            entity.HasKey(e => e.IdPuesto);

            entity.Property(e => e.IdPuesto).ValueGeneratedNever();
            entity.Property(e => e.FechaReg)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RTF_Textos>(entity =>
        {
            entity.HasKey(e => e.IdTexto)
                .HasName("PK_BL_DOCSTEXTO2")
                .IsClustered(false);

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Texto).HasColumnType("text");
        });

        modelBuilder.Entity<SIRADIG_FamiliarGastoEducacion>(entity =>
        {
            entity.HasKey(e => new { e.IdPersona, e.tipoDocFamiliar, e.numeroDocFamiliar, e.Periodo });

            entity.Property(e => e.numeroDocFamiliar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.apellidoNombreFamiliar)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SIRADIG_Parentescos>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SIRADIG_ParentescosRelacion>(entity =>
        {
            entity.HasKey(e => new { e.IdParentesco, e.IdParentescoSIRADIG });
        });

        modelBuilder.Entity<SIRADIG_Secuencia>(entity =>
        {
            entity.HasKey(e => new { e.CUIL, e.Periodo });

            entity.Property(e => e.CUIL)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SIRADIG_Variables>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SIRADIG_VarGanancias");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CodVariable)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Planilla)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .IsFixedLength();
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<TABLAS>(entity =>
        {
            entity.HasKey(e => e.CODTAB).HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("CTRL_FACTOR"));

            entity.Property(e => e.CODTAB).ValueGeneratedNever();
            entity.Property(e => e.ACTUCOT)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength();
            entity.Property(e => e.DECIMALES).HasDefaultValue((byte)1);
            entity.Property(e => e.FACTOR).HasDefaultValue((short)1);
            entity.Property(e => e.NOMBRE)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SIMBOLO)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TIPO)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TIPODOC>(entity =>
        {
            entity.HasKey(e => e.CODDOC).HasFillFactor(90);

            entity.Property(e => e.CODDOC)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TableConstraint>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TableConstraint");

            entity.Property(e => e.Constraint_name).HasMaxLength(128);
            entity.Property(e => e.Referenced_Column_Name).HasMaxLength(128);
            entity.Property(e => e.Referenced_Object_name).HasMaxLength(128);
            entity.Property(e => e.Referencing_Object_name).HasMaxLength(128);
            entity.Property(e => e.referencing_column_Name).HasMaxLength(128);
        });

        modelBuilder.Entity<Talonarios>(entity =>
        {
            entity.HasKey(e => new { e.nroTalonario, e.CodEmp }).HasFillFactor(90);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TipoDocSync>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CODDOC)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<USUARIOS>(entity =>
        {
            entity.HasKey(e => e.USERNAME).HasFillFactor(90);

            entity.Property(e => e.USERNAME)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AXFEC).HasDefaultValue((byte)1);
            entity.Property(e => e.EMAIL)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NOMBRE)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TITULOINF)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TITULOINFBASLB)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.CODEMPNavigation).WithMany(p => p.USUARIOS)
                .HasForeignKey(d => d.CODEMP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIOS_EMPRESAS");
        });

        modelBuilder.Entity<USUEMPRESAS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("USUEMPRESAS");

            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.username)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UsuariosYGrupos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UsuariosYGrupos");

            entity.Property(e => e.Clave)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VIEW_LiqAppFaltantes>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_LiqAppFaltantes");

            entity.Property(e => e.Idliquidacion).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VISTAATRIBUTOSEMP>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VISTAATRIBUTOSEMP");

            entity.Property(e => e.CODATR)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DESCRIPCION)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PREFIATR)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VISTAVARIABLES>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VISTAVARIABLES");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.codVariable)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.idvariable)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ValoresEspeciales>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ValoresEspeciales");

            entity.Property(e => e.CodVariable)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Parametro)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VarAcumVisor4ta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VarAcumVisor4ta");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VarSiradig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VarSiradig");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VariablesDeAuditoria>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VariablesDeAuditoria");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VariablesHistoricas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VariablesHistoricas");

            entity.Property(e => e.CodVariable)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MesLiq).HasColumnType("smalldatetime");
            entity.Property(e => e.Valor).HasColumnType("decimal(38, 5)");
        });

        modelBuilder.Entity<vAGENDA_ALERTA>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.SubTipoNombre)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TipoFecha)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoNombre)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAGENDA_ALERTA_1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA_1");

            entity.Property(e => e.FV).HasColumnType("datetime");
            entity.Property(e => e.Fecha)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Plan)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Tipo_de_Fecha)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo de Fecha");
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAGENDA_ALERTA_10>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA_10");

            entity.Property(e => e.Días_restantes_para_liquidar)
                .HasColumnType("decimal(38, 5)")
                .HasColumnName("Días restantes para liquidar");
            entity.Property(e => e.FV).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Fecha_base_de_antiguedad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Fecha base de antiguedad");
            entity.Property(e => e.Legajo___Apellido_y_Nombre)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("Legajo - Apellido y Nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Vencimiento).HasColumnType("datetime");
        });

        modelBuilder.Entity<vAGENDA_ALERTA_11>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA_11");

            entity.Property(e => e.Devolución)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ElementoDeTrabajo)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.FV).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Persona___Apellido_y_Nombre)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("Persona - Apellido y Nombre");
            entity.Property(e => e.Puesto).IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAGENDA_ALERTA_12>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA_12");

            entity.Property(e => e.ElementoDeTrabajo)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.FV).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Persona___Apellido_y_Nombre)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("Persona - Apellido y Nombre");
            entity.Property(e => e.PróximaEntrega)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Puesto).IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAGENDA_ALERTA_2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA_2");

            entity.Property(e => e.Evidencia)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.FV).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Persona___Apellido_y_Nombre)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("Persona - Apellido y Nombre");
            entity.Property(e => e.Puesto).IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Vencimiento)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAGENDA_ALERTA_3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA_3");

            entity.Property(e => e.Evaluación)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.FV).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Persona___Apellido_y_Nombre)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("Persona - Apellido y Nombre");
            entity.Property(e => e.Plan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Puesto).IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Vencimiento)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAGENDA_ALERTA_4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA_4");

            entity.Property(e => e.Capacitación)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.FV).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Persona___Apellido_y_Nombre)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("Persona - Apellido y Nombre");
            entity.Property(e => e.Plan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Puesto).IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Vencimiento)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAGENDA_ALERTA_5>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA_5");

            entity.Property(e => e.FV).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Habilidad)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.Persona___Apellido_y_Nombre)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("Persona - Apellido y Nombre");
            entity.Property(e => e.Puesto).IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Vencimiento)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAGENDA_ALERTA_6>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA_6");

            entity.Property(e => e.FV).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Ingreso)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Legajo___Apellido_y_Nombre)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("Legajo - Apellido y Nombre");
            entity.Property(e => e.Modalidad_de_contratación)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Modalidad de contratación");
            entity.Property(e => e.Puesto).IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Vencimiento).HasColumnType("datetime");
        });

        modelBuilder.Entity<vAGENDA_ALERTA_7>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA_7");

            entity.Property(e => e.FV).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Jubilación).HasColumnType("smalldatetime");
            entity.Property(e => e.Legajo___Apellido_y_Nombre)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("Legajo - Apellido y Nombre");
            entity.Property(e => e.Nacimiento)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Puesto).IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAGENDA_ALERTA_8>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA_8");

            entity.Property(e => e.FV).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Nacimiento)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Persona___Apellido_y_Nombre)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("Persona - Apellido y Nombre");
            entity.Property(e => e.Puesto).IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAGENDA_ALERTA_9>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAGENDA_ALERTA_9");

            entity.Property(e => e.FV).HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Inicio)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Legajo___Apellido_y_Nombre)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("Legajo - Apellido y Nombre");
            entity.Property(e => e.Puesto).IsUnicode(false);
            entity.Property(e => e.Suceso)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Vencimiento)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAUDI_ACUMULADORES>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_ACUMULADORES");

            entity.Property(e => e.Acumulador)
                .HasMaxLength(63)
                .IsUnicode(false);
            entity.Property(e => e.Años_a_considerar)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Años a considerar");
            entity.Property(e => e.Considerar_Imp__Prorrateados)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Considerar Imp. Prorrateados");
            entity.Property(e => e.Incluir_Liq__Actual)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Incluir Liq. Actual");
            entity.Property(e => e.Incluir_concepto_de_Asig__Fam_)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Incluir concepto de Asig. Fam.");
            entity.Property(e => e.Incluir_concepto_de_Contribuciones)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Incluir concepto de Contribuciones");
            entity.Property(e => e.Incluir_concepto_de_Haberes)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Incluir concepto de Haberes");
            entity.Property(e => e.Incluir_concepto_de_Redondeo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Incluir concepto de Redondeo");
            entity.Property(e => e.Incluir_concepto_de_Retenciones)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Incluir concepto de Retenciones");
            entity.Property(e => e.Liquidaciones_anteriores_del_mes_actual)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Liquidaciones anteriores del mes actual");
            entity.Property(e => e.Mayor_Valor)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Mayor Valor");
            entity.Property(e => e.Meses_a_considerar)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("Meses a considerar");
            entity.Property(e => e.Permite_carga_inicial)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Permite carga inicial");
            entity.Property(e => e.Sólo_última_liquidación)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Sólo última liquidación");
            entity.Property(e => e.Ultima_Liq__Mes_Actual)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Ultima Liq. Mes Actual");
        });

        modelBuilder.Entity<vAUDI_ACUMULADORES_DET1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_ACUMULADORES_DET1");

            entity.Property(e => e.Concepto)
                .HasMaxLength(85)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAUDI_CONCEPTOS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_CONCEPTOS");

            entity.Property(e => e.Abril)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Agosto)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Auxiliar_habilitado_para_prorratear)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Auxiliar habilitado para prorratear");
            entity.Property(e => e.Concepto)
                .HasMaxLength(77)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta_Acreedor_x_Defecto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Cuenta Acreedor x Defecto");
            entity.Property(e => e.Cuenta_Deudor_x_Defecto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Cuenta Deudor x Defecto");
            entity.Property(e => e.Dependencia_Centro_de_Costo)
                .HasMaxLength(43)
                .IsUnicode(false)
                .HasColumnName("Dependencia Centro de Costo");
            entity.Property(e => e.Diciembre)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Enero)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Es_Auxiliar)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Es Auxiliar");
            entity.Property(e => e.Es_Ganancias)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Es Ganancias");
            entity.Property(e => e.Febrero)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Formula).HasColumnType("text");
            entity.Property(e => e.Julio)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Junio)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Marzo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Mayo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Mes_Actual)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Mes Actual");
            entity.Property(e => e.Meses_Anteriores).HasColumnName("Meses Anteriores");
            entity.Property(e => e.Meses_Posteriores).HasColumnName("Meses Posteriores");
            entity.Property(e => e.Noviembre)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Octubre)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Período_liquidaciones_anteriores)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Período liquidaciones anteriores");
            entity.Property(e => e.Prorratea_para_ganancias)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Prorratea para ganancias");
            entity.Property(e => e.Recibo_Observación)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Recibo Observación");
            entity.Property(e => e.Recibo_Unidad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Recibo Unidad");
            entity.Property(e => e.Recibo_Variable)
                .HasMaxLength(113)
                .IsUnicode(false)
                .HasColumnName("Recibo Variable");
            entity.Property(e => e.Septiembre)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Sin_Retenciones)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Sin Retenciones");
            entity.Property(e => e.Tipo_prorrateo_períodos)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("Tipo prorrateo períodos");
            entity.Property(e => e.Variable_Requerida)
                .HasMaxLength(63)
                .IsUnicode(false)
                .HasColumnName("Variable Requerida");
        });

        modelBuilder.Entity<vAUDI_CONCEPTOS_DET1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_CONCEPTOS_DET1");

            entity.Property(e => e.Acumulador)
                .HasMaxLength(71)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAUDI_CONCEPTOS_DET2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_CONCEPTOS_DET2");

            entity.Property(e => e.Cuenta_Debe)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Cuenta Debe");
            entity.Property(e => e.Cuenta_Haber)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Cuenta Haber");
            entity.Property(e => e.Liquidación)
                .HasMaxLength(56)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAUDI_FAMILIARES>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_FAMILIARES");

            entity.Property(e => e.AnioEnCurso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CUIL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoBaja)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(47)
                .IsUnicode(false);
            entity.Property(e => e.Domicilio)
                .HasMaxLength(53)
                .IsUnicode(false);
            entity.Property(e => e.Escolaridad)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.Estado_Civil)
                .HasMaxLength(27)
                .IsUnicode(false)
                .HasColumnName("Estado Civil");
            entity.Property(e => e.Familiar_Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Familiar Apellido");
            entity.Property(e => e.Familiar_Apellido_Casada)
                .HasMaxLength(28)
                .IsUnicode(false)
                .HasColumnName("Familiar Apellido Casada");
            entity.Property(e => e.Familiar_Nombres)
                .HasMaxLength(28)
                .IsUnicode(false)
                .HasColumnName("Familiar Nombres");
            entity.Property(e => e.FecACargo).HasColumnType("smalldatetime");
            entity.Property(e => e.FecVencDeducGan).HasColumnType("datetime");
            entity.Property(e => e.Fecha_de_Nacimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha de Nacimiento");
            entity.Property(e => e.Localidad)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(59)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Parentesco)
                .HasMaxLength(76)
                .IsUnicode(false);
            entity.Property(e => e.Persona)
                .HasMaxLength(51)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.TipoVencAsigFam)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoVencDeducGan)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoVencObraSoc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<vAUDI_FAMILIARES_DET1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_FAMILIARES_DET1");

            entity.Property(e => e.FecACargoDesde).HasColumnType("smalldatetime");
            entity.Property(e => e.FecACargoHasta).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<vAUDI_LEGAJOS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_LEGAJOS");

            entity.Property(e => e.Actividad)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.AporteVolunt).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CapitalRecomp).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Cargo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Categoría)
                .HasMaxLength(63)
                .IsUnicode(false);
            entity.Property(e => e.Centro_A)
                .HasMaxLength(29)
                .IsUnicode(false)
                .HasColumnName("Centro A");
            entity.Property(e => e.Centro_B)
                .HasMaxLength(29)
                .IsUnicode(false)
                .HasColumnName("Centro B");
            entity.Property(e => e.Condición_Laboral)
                .HasMaxLength(67)
                .IsUnicode(false)
                .HasColumnName("Condición Laboral");
            entity.Property(e => e.Convenio)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(49)
                .IsUnicode(false);
            entity.Property(e => e.ExcedenteAOS).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ExcedenteASS).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Fecha_Base_de_Antigüedad)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha Base de Antigüedad");
            entity.Property(e => e.Fecha_Base_de_Indemnización)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Base de Indemnización");
            entity.Property(e => e.Fecha_de_Egreso)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha de Egreso");
            entity.Property(e => e.Fecha_de_Ingreso)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha de Ingreso");
            entity.Property(e => e.Incapacidad)
                .HasMaxLength(57)
                .IsUnicode(false);
            entity.Property(e => e.Legajo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Lugar_de_Trabajo)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasColumnName("Lugar de Trabajo");
            entity.Property(e => e.Modalidad_de_Contratación)
                .HasMaxLength(69)
                .IsUnicode(false)
                .HasColumnName("Modalidad de Contratación");
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.ObservsLibro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Oficina)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Persona)
                .HasMaxLength(51)
                .IsUnicode(false);
            entity.Property(e => e.PorApoAdi).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PorTareaDif).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.RedUltLiq).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Regimen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Situación_de_Revista)
                .HasMaxLength(69)
                .IsUnicode(false)
                .HasColumnName("Situación de Revista");
            entity.Property(e => e.SueldoBasicoRec).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TelDirecto)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.TelInterno)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(59)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAUDI_LEGAJOS_DET1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_LEGAJOS_DET1");

            entity.Property(e => e.Atributo)
                .HasMaxLength(26)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(31)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAUDI_LEGAJOS_DET2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_LEGAJOS_DET2");

            entity.Property(e => e.FecAlta).HasColumnType("smalldatetime");
            entity.Property(e => e.NroInscrLegajo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Repartición)
                .HasMaxLength(29)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAUDI_NOVGANANCIAS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_NOVGANANCIAS");
        });

        modelBuilder.Entity<vAUDI_NOVGANANCIAS_DET>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_NOVGANANCIAS_DET");

            entity.Property(e => e.CUIT)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionA)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionB)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Planilla)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.VtoMesAnioDesde).HasColumnType("datetime");
            entity.Property(e => e.VtoMesAnioHasta).HasColumnType("datetime");
        });

        modelBuilder.Entity<vAUDI_PERSONAS>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_PERSONAS");

            entity.Property(e => e.ApellidoCasada)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.CUIL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(47)
                .IsUnicode(false);
            entity.Property(e => e.Domicilio)
                .HasMaxLength(142)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado_Civil)
                .HasMaxLength(27)
                .IsUnicode(false)
                .HasColumnName("Estado Civil");
            entity.Property(e => e.Fecha_de_Nacimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha de Nacimiento");
            entity.Property(e => e.Localidad)
                .HasMaxLength(68)
                .IsUnicode(false);
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(59)
                .IsUnicode(false);
            entity.Property(e => e.Nombres_y_Apellido)
                .HasMaxLength(58)
                .IsUnicode(false)
                .HasColumnName("Nombres y Apellido");
            entity.Property(e => e.Persona)
                .HasMaxLength(51)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Teléfono)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAUDI_PERSONAS_DET1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_PERSONAS_DET1");

            entity.Property(e => e.Atributo)
                .HasMaxLength(26)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(31)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAUDI_VARIABLES>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_VARIABLES");

            entity.Property(e => e.AcumulaPor)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Acumular_Valores)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Acumular Valores");
            entity.Property(e => e.Establecer_Topes)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Establecer Topes");
            entity.Property(e => e.Tope_Atributo)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("Tope Atributo");
            entity.Property(e => e.Tope_Tipo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Tope Tipo");
            entity.Property(e => e.Variable)
                .HasMaxLength(63)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAUDI_VARIABLES_DET1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAUDI_VARIABLES_DET1");

            entity.Property(e => e.Atributo_Valor)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("Atributo Valor");
            entity.Property(e => e.Tope_Anual)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Tope Anual");
            entity.Property(e => e.Tope_Mensual)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Tope Mensual");
            entity.Property(e => e.Tope_Novedad)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Tope Novedad");
        });

        modelBuilder.Entity<vAtributosLeg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAtributosLeg");

            entity.Property(e => e.Atributo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodAtr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Valor)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<vAudiLiq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAudiLiq");

            entity.Property(e => e.ABM)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<vAuditoriaCampos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAuditoriaCampos");

            entity.Property(e => e.Codigo)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<vAuditoriaMaestros>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAuditoriaMaestros");

            entity.Property(e => e.CampoCod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodCampoLogico)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CodObjeto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Entidad)
                .HasMaxLength(112)
                .IsUnicode(false);
            entity.Property(e => e.Maestro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreMaquina)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NuevoValor).HasColumnType("text");
            entity.Property(e => e.ObjetoBase)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Operacion)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("text");
            entity.Property(e => e.campo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.fecha).HasColumnType("datetime");
            entity.Property(e => e.usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAutogestion_CtaBancaria>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAutogestion_CtaBancaria");

            entity.Property(e => e.CBU)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NroInscrLegajo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAutogestion_Familiares>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAutogestion_Familiares");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FecACargo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FecNacimiento)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.Parentesco)
                .HasMaxLength(70)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAutogestion_Familiares2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAutogestion_Familiares2");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FecACargo).HasMaxLength(30);
            entity.Property(e => e.FecNacimiento).HasMaxLength(30);
            entity.Property(e => e.Nombres)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.Parentesco)
                .HasMaxLength(70)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAutogestion_Legajos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAutogestion_Legajos");

            entity.Property(e => e.Banco)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BancoCBU)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Convenio)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(49)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FechaAntiguedad)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaEgreso)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaIndemnizacion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngreso)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaJubilacion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LegajoCodigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.LugarDeTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModContratacion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocial)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Regimen)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Telefono_Directo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Telefono-Directo");
            entity.Property(e => e.Telefono_Interno)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Telefono-Interno");
            entity.Property(e => e.ZonaGeografica)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAutogestion_Legajos2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAutogestion_Legajos2");

            entity.Property(e => e.Banco)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BancoCBU)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Convenio)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(49)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FechaAntiguedad).HasMaxLength(30);
            entity.Property(e => e.FechaEgreso).HasMaxLength(30);
            entity.Property(e => e.FechaIndemnizacion).HasMaxLength(30);
            entity.Property(e => e.FechaIngreso).HasMaxLength(30);
            entity.Property(e => e.FechaJubilacion).HasMaxLength(30);
            entity.Property(e => e.LegajoCodigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.LugarDeTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModContratacion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocial)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Regimen)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Telefono_Directo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Telefono-Directo");
            entity.Property(e => e.Telefono_Interno)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Telefono-Interno");
            entity.Property(e => e.ZonaGeografica)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAutogestion_LoguinsIni>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAutogestion_LoguinsIni");

            entity.Property(e => e.Contrasenia)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAutogestion_ManagersYEmpleados>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAutogestion_ManagersYEmpleados");
        });

        modelBuilder.Entity<vAutogestion_Personas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAutogestion_Personas");

            entity.Property(e => e.Apellido)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoCasada)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.CUIL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DNI)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCalle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCodPos)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioDepto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioLoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioNro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioPiso)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioProv)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.EmailPersonal)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FecNacimiento)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.PersonaCodigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAutogestion_Personas2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAutogestion_Personas2");

            entity.Property(e => e.Apellido)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoCasada)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.CUIL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DNI)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCalle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCodPos)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioDepto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioLoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioNro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioPiso)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioProv)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.EmailPersonal)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FecNacimiento).HasMaxLength(30);
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.PersonaCodigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAutogestion_Puestos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAutogestion_Puestos");

            entity.Property(e => e.Empresa).HasMaxLength(10);
            entity.Property(e => e.NombrePuesto)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vAutogestion_Recibos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAutogestion_Recibos");

            entity.Property(e => e.ArchivoGananciasUpload).HasColumnType("datetime");
            entity.Property(e => e.Clave)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(49)
                .IsUnicode(false);
            entity.Property(e => e.FTPUpLoad).HasColumnType("datetime");
            entity.Property(e => e.Firmado_Fecha).HasColumnType("datetime");
            entity.Property(e => e.LegajoCodigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Liquidacion_Codigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Liquidacion_Mes).HasColumnType("smalldatetime");
            entity.Property(e => e.Liquidacion_Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LugarDeTrabajo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observacion)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.PDF_Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PDF_RutaFTP)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.PDF_RutaLOC)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.Visualizado).HasColumnType("datetime");
        });

        modelBuilder.Entity<vAutogestion_RecibosDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vAutogestion_RecibosDetalle");

            entity.Property(e => e.Apellido_y_Nombres)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Apellido y Nombres");
            entity.Property(e => e.Banco)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Clave)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Convenio)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(49)
                .IsUnicode(false);
            entity.Property(e => e.Estado_Civil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado Civil");
            entity.Property(e => e.Fecha_Ingreso)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Ingreso");
            entity.Property(e => e.Firmado)
                .HasMaxLength(34)
                .IsUnicode(false);
            entity.Property(e => e.Liquidación)
                .HasMaxLength(84)
                .IsUnicode(false);
            entity.Property(e => e.Modalidad_Contratación)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Modalidad Contratación");
            entity.Property(e => e.Obra_Social)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Obra Social");
            entity.Property(e => e.Observación)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Situación_de_Revista)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Situación de Revista");
            entity.Property(e => e.Visualizado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vBl_Legajos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vBl_Legajos");

            entity.Property(e => e.AcAnRet).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.AporteVolunt).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CAT)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CapitalRecomp).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Cargo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodigoBaja)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ExcedenteAOS).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ExcedenteASS).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.FecBaseAnt).HasColumnType("smalldatetime");
            entity.Property(e => e.FecBaseIndem).HasColumnType("datetime");
            entity.Property(e => e.FecEgreso).HasColumnType("smalldatetime");
            entity.Property(e => e.FecIngreso).HasColumnType("smalldatetime");
            entity.Property(e => e.FecJubilacion).HasColumnType("smalldatetime");
            entity.Property(e => e.Legajo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.ObservsLibro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Oficina)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PorApoAdi).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PorTareaDif).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.RedUltLiq).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Regimen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SueldoBasicoRec).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.TareaDesemp)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TelDirecto)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.TelInterno)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.email)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vCtaBancaria>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vCtaBancaria");

            entity.Property(e => e.NroInscrLegajo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vDiasLiquidadosAnual>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vDiasLiquidadosAnual");

            entity.Property(e => e.ImporteLiq).HasColumnType("decimal(38, 5)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(49)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vDiasLiquidadosMensual>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vDiasLiquidadosMensual");

            entity.Property(e => e.ImporteLiq).HasColumnType("decimal(38, 5)");
            entity.Property(e => e.Mes)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(49)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vDiasLiquidadosNovedad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vDiasLiquidadosNovedad");

            entity.Property(e => e.ImporteLiq).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(49)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vHabilidadesAlternativas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vHabilidadesAlternativas");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vHabilidadesLegajos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vHabilidadesLegajos");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vHabilidadesPuestos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vHabilidadesPuestos");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cumple)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Imprescindible)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vLegajosCBU>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vLegajosCBU");

            entity.Property(e => e.CBU)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FormaPago)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vLegajosLiquidados>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vLegajosLiquidados");

            entity.Property(e => e.FechaDesde).HasColumnType("datetime");
            entity.Property(e => e.FechaHasta).HasColumnType("datetime");
        });

        modelBuilder.Entity<vLegajosOrganigrama>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vLegajosOrganigrama");

            entity.Property(e => e.CAT)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CUIL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CapitalRecomp).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cobertura_SVO)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Cobertura SVO");
            entity.Property(e => e.CodCat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodConvenio)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CodPersona)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Denominacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocNro)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FecBaseAnt).HasColumnType("smalldatetime");
            entity.Property(e => e.FecBaseIndem).HasColumnType("datetime");
            entity.Property(e => e.FecEgreso).HasColumnType("smalldatetime");
            entity.Property(e => e.FecIngreso).HasColumnType("smalldatetime");
            entity.Property(e => e.FecJubilacion).HasColumnType("smalldatetime");
            entity.Property(e => e.Incorporado)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Legajo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.NomCat)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.NombreCentroA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NombreCentroB)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Observslibro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Oficina)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PagoLugar)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PorApoAdi).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PorTareaDif).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Regimen)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.TelDirecto)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.TelInterno)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.eMail)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vOrdenLiquidaciones>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vOrdenLiquidaciones");

            entity.Property(e => e.FechaDesde).HasColumnType("datetime");
            entity.Property(e => e.FechaHasta).HasColumnType("datetime");
        });

        modelBuilder.Entity<vOrdenNovedades>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vOrdenNovedades");

            entity.Property(e => e.FechaDesde).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaHasta).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<vOrgPuestosLegajos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vOrgPuestosLegajos");

            entity.Property(e => e.CodEmp).HasMaxLength(10);
            entity.Property(e => e.CodLegajo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CodPersona)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.NombrePersona)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.NombrePuesto)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vOrganigrama>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vOrganigrama");

            entity.Property(e => e.Legajo_Codigo)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Legajo_Nombre)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Puesto_Codigo)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Puesto_Nombre)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vPBI_Categorias>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPBI_Categorias");

            entity.Property(e => e.Categoria).ValueGeneratedOnAdd();
            entity.Property(e => e.CodCat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DescCombinada)
                .HasMaxLength(63)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vPBI_CentrosA>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPBI_CentrosA");

            entity.Property(e => e.CenPrefi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroAx)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CentroDesc)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.CodCen)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdCentroAp).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<vPBI_CentrosB>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPBI_CentrosB");

            entity.Property(e => e.CenPrefi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroAx)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CentroDesc)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.CodCen)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdCentroAp).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<vPBI_Convenios>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPBI_Convenios");

            entity.Property(e => e.Convenio)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Denominacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DescCombinada)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vPBI_Legajos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPBI_Legajos");

            entity.Property(e => e.Banco)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BancoCBU)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CategorÝa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CentroA)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroAx)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CentroB)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CentroBx)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Convenio)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(49)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FechaAntiguedad)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaEgreso)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaIndemnizacion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngreso)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaJubilacion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LegajoCodigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.LugarDeTrabajo)
                .HasMaxLength(61)
                .IsUnicode(false);
            entity.Property(e => e.ModContratacion)
                .HasMaxLength(69)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocial)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.Regimen)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Telefono_Directo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Telefono-Directo");
            entity.Property(e => e.Telefono_Interno)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Telefono-Interno");
            entity.Property(e => e.ZonaGeografica)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vPBI_LugaresDeTrabajo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPBI_LugaresDeTrabajo");

            entity.Property(e => e.Codigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LugarDeTrabajo)
                .HasMaxLength(61)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vPBI_ModContrataciones>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPBI_ModContrataciones");

            entity.Property(e => e.DescCombinada)
                .HasMaxLength(69)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Modalidad_Contratacion).HasColumnName("Modalidad Contratacion");
        });

        modelBuilder.Entity<vPBI_Personas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPBI_Personas");

            entity.Property(e => e.Apellido)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoCasada)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.CUIL)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DNI)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCalle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioCodPos)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioDepto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioLoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioNro)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioPiso)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioProv)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.EmailPersonal)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FecNacimiento)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.PersonaCodigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vPBI_Recibos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPBI_Recibos");

            entity.Property(e => e.Clave)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(49)
                .IsUnicode(false);
            entity.Property(e => e.LegajoCodigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Liquidacion_Codigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Liquidacion_Mes).HasColumnType("smalldatetime");
            entity.Property(e => e.Liquidacion_Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LugarDeTrabajo)
                .HasMaxLength(61)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vPBI_RecibosDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPBI_RecibosDetalle");

            entity.Property(e => e.Apellido_y_Nombres)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Apellido y Nombres");
            entity.Property(e => e.Banco)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Clave)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Convenio)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(49)
                .IsUnicode(false);
            entity.Property(e => e.Estado_Civil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado Civil");
            entity.Property(e => e.Fecha_Ingreso)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Ingreso");
            entity.Property(e => e.Liquidacion)
                .HasMaxLength(84)
                .IsUnicode(false);
            entity.Property(e => e.Modalidad_Contratacion).HasColumnName("Modalidad Contratacion");
            entity.Property(e => e.Obra_Social)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Obra Social");
            entity.Property(e => e.Situacion_de_Revista)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Situacion de Revista");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vPBI_Reparticiones>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPBI_Reparticiones");

            entity.Property(e => e.Denominacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DescCombinada)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.Obra_Social)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Obra Social");
        });

        modelBuilder.Entity<vPBI_TotalNeto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPBI_TotalNeto");

            entity.Property(e => e.Apellido_y_Nombres)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Apellido y Nombres");
            entity.Property(e => e.Banco)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodLegajoNomApe)
                .HasMaxLength(51)
                .IsUnicode(false);
            entity.Property(e => e.Convenio)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(49)
                .IsUnicode(false);
            entity.Property(e => e.Estado_Civil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado Civil");
            entity.Property(e => e.Fecha_Ingreso)
                .HasColumnType("datetime")
                .HasColumnName("Fecha Ingreso");
            entity.Property(e => e.LegajoCodigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Liquidacion_Mes).HasColumnType("smalldatetime");
            entity.Property(e => e.Liquidacion_Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lugar_de_Trabajo)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasColumnName("Lugar de Trabajo");
            entity.Property(e => e.Modalidad_Contratacion).HasColumnName("Modalidad Contratacion");
            entity.Property(e => e.Obra_Social)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Obra Social");
            entity.Property(e => e.Situacion_de_Revista)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Situacion de Revista");
            entity.Property(e => e.Total_Bruto)
                .HasColumnType("decimal(38, 5)")
                .HasColumnName("Total Bruto");
            entity.Property(e => e.Total_Neto)
                .HasColumnType("decimal(38, 5)")
                .HasColumnName("Total Neto");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vPuestosEmpresas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPuestosEmpresas");

            entity.Property(e => e.CodEmp).HasMaxLength(10);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IdDescripcionPuestoSuperior)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.NombrePuestoSuperior)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vRegistroVacAnuales>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vRegistroVacAnuales");

            entity.Property(e => e.FecBaseAnt).HasColumnType("smalldatetime");
            entity.Property(e => e.ImporteLiq).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.MesLiq).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vReparticionesLegajos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vReparticionesLegajos");

            entity.Property(e => e.BancoPagoCod)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.BancoPagoDesc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NroInscrEmpresa)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.NroInscrLegajo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocialCod)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocialDesc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoObraSocial)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vReparticionesLegajos2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vReparticionesLegajos2");

            entity.Property(e => e.BancoPagoCod)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.BancoPagoDesc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CBU)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NroInscrLegajo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocialCod)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ObraSocialDesc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoObraSocial)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vResponsablesCapacitaciones>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vResponsablesCapacitaciones");

            entity.Property(e => e.Capacitacion)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.PlanCap)
                .HasMaxLength(513)
                .IsUnicode(false);
            entity.Property(e => e.ResponsablesPersonas).IsUnicode(false);
        });

        modelBuilder.Entity<vTodasLasPersonas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vTodasLasPersonas");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Eliminado)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vTodasLasVariables>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vTodasLasVariables");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Eliminado)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vTodosLosAcumuladores>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vTodosLosAcumuladores");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Eliminado)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vTodosLosConceptos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vTodosLosConceptos");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Eliminado)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vTodosLosLegajos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vTodosLosLegajos");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Eliminado)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vVariablesDeNovedades>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vVariablesDeNovedades");

            entity.Property(e => e.CodVariable)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
