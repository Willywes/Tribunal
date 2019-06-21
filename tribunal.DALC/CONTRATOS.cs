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
    
    public partial class CONTRATOS
    {
        public CONTRATOS()
        {
            this.CONTRATOS_CLIENTES = new HashSet<CONTRATOS_CLIENTES>();
            this.DOCUMENTOS = new HashSet<DOCUMENTOS>();
            this.PAGOS = new HashSet<PAGOS>();
        }
    
        public decimal ID_CONTRATO { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public System.DateTime FECHA_TERMINO { get; set; }
        public decimal ID_CONTRATO_ESTADO { get; set; }
        public Nullable<decimal> ID_PRESUPUESTO { get; set; }
        public Nullable<decimal> ID_ABOGADO { get; set; }
        public Nullable<decimal> ID_PLAN_PAGO { get; set; }
        public System.DateTime CREADO { get; set; }
        public Nullable<System.DateTime> MODIFICADO { get; set; }
        public short APROBADO_ABOGADO { get; set; }
        public short APROBADO_CLIENTE { get; set; }
        public decimal ID_FORMA_PAGO { get; set; }
        public Nullable<decimal> ID_CAUSA { get; set; }
    
        public virtual CONTRATO_ESTADOS CONTRATO_ESTADOS { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
        public virtual ICollection<CONTRATOS_CLIENTES> CONTRATOS_CLIENTES { get; set; }
        public virtual ICollection<DOCUMENTOS> DOCUMENTOS { get; set; }
        public virtual FORMA_PAGO FORMA_PAGO { get; set; }
        public virtual ICollection<PAGOS> PAGOS { get; set; }
        public virtual PLAN_PAGO PLAN_PAGO { get; set; }
        public virtual PRESUPUESTOS PRESUPUESTOS { get; set; }
    }
}
