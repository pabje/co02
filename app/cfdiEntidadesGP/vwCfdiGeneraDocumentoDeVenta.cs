//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cfdiEntidadesGP
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwCfdiGeneraDocumentoDeVenta
    {
        public int soptype { get; set; }
        public string sopnumbe { get; set; }
        public string CUSTNMBR { get; set; }
        public int cantidadDecimales { get; set; }
        public string consecutivoDocumento { get; set; }
        public string cargosdescuentos_codigo { get; set; }
        public string cargosdescuentos_descripcion { get; set; }
        public int cargosdescuentos_indicador { get; set; }
        public int cargosdescuentos_monto { get; set; }
        public int cargosdescuentos_montobase { get; set; }
        public int cargodescuentos_porcentaje { get; set; }
        public string cargosdescuentos_secuencia { get; set; }
        public string cliente_nitProveedorReceptor { get; set; }
        public string cliente_telefono { get; set; }
        public string cliente_difciudad { get; set; }
        public string cliente_difcodigoDepartamento { get; set; }
        public string cliente_difdepartamento { get; set; }
        public string cliente_difdireccion { get; set; }
        public string cliente_diflenguaje { get; set; }
        public string cliente_difmunicipio { get; set; }
        public string cliente_difpais { get; set; }
        public string cliente_difzonapostal { get; set; }
        public string cliente_email { get; set; }
        public string cliente_nombreRegistroRUT { get; set; }
        public string cliente_numeroIdentificacion { get; set; }
        public string cliente_numeroIdentificacionDV { get; set; }
        public int cliente_tipoIdentificacion { get; set; }
        public string cliente_nombreComercial { get; set; }
        public string cliente_nombreRazonSocial { get; set; }
        public string cliente_notificar { get; set; }
        public string cliente_numeroDocumento { get; set; }
        public string cliente_tipoPersona { get; set; }
        public string cliente_actividadEconomicaCIIU { get; set; }
        public string fechaEmision { get; set; }
        public string fechaVencimiento { get; set; }
        public string moneda { get; set; }
        public string rangonumeracion { get; set; }
        public decimal redondeoaplicado { get; set; }
        public int tasaDeCambio { get; set; }
        public decimal tc_baseMonedaDestino { get; set; }
        public string tc_fechaDeTasaDeCambio { get; set; }
        public string tc_monedaOrigen { get; set; }
        public string tc_monedaDestino { get; set; }
        public string tipoDocumento { get; set; }
        public string tipoOperacion { get; set; }
        public decimal totalBaseImponible { get; set; }
        public decimal totalBrutoconImpuestos { get; set; }
        public decimal totalMonto { get; set; }
        public int totalProductos { get; set; }
        public decimal totalSinImpuestos { get; set; }
    }
}
