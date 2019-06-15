//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tribunal.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIOS
    {
        public USUARIOS()
        {
            this.CONTRATOS = new HashSet<CONTRATOS>();
            this.CONTRATOS_CLIENTES = new HashSet<CONTRATOS_CLIENTES>();
            this.PRESUPUESTOS = new HashSet<PRESUPUESTOS>();
            this.SOLICITUDES = new HashSet<SOLICITUDES>();
            this.SOLICITUDES1 = new HashSet<SOLICITUDES>();
            this.EMPRESAS = new HashSet<EMPRESAS>();
            this.NOTARIAS = new HashSet<NOTARIAS>();
        }
    
        public decimal ID_USUARIO { get; set; }
        public string RUT { get; set; }
        public string PATERNO { get; set; }
        public string MATERNO { get; set; }
        public string NOMBRES { get; set; }
        public Nullable<System.DateTime> F_NAC { get; set; }
        public string EMAIL { get; set; }
        public string CLAVE { get; set; }
        public Nullable<int> CELULAR { get; set; }
        public Nullable<int> TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public short ACTIVO { get; set; }
        public Nullable<decimal> ID_ROL { get; set; }
        public System.DateTime CREADO { get; set; }
        public Nullable<System.DateTime> MODIFICADO { get; set; }
    
        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }
        public virtual ICollection<CONTRATOS_CLIENTES> CONTRATOS_CLIENTES { get; set; }
        public virtual ICollection<PRESUPUESTOS> PRESUPUESTOS { get; set; }
        public virtual ROLES ROLES { get; set; }
        public virtual ICollection<SOLICITUDES> SOLICITUDES { get; set; }
        public virtual ICollection<SOLICITUDES> SOLICITUDES1 { get; set; }
        public virtual ICollection<EMPRESAS> EMPRESAS { get; set; }
        public virtual ICollection<NOTARIAS> NOTARIAS { get; set; }
    }
}