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
    
    public partial class SOLICITUDES
    {
        public SOLICITUDES()
        {
            this.PRESUPUESTOS = new HashSet<PRESUPUESTOS>();
        }
    
        public decimal ID_SOLICITUD { get; set; }
        public System.DateTime FECHA_HORA { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal ID_TIPO_SOLICITUD { get; set; }
        public decimal ID_ESTADO_SOLICITUD { get; set; }
        public System.DateTime CREADO { get; set; }
        public Nullable<System.DateTime> MODIFICADO { get; set; }
        public decimal ID_CLIENTE { get; set; }
        public Nullable<decimal> ID_TECNICO { get; set; }
    
        public virtual ICollection<PRESUPUESTOS> PRESUPUESTOS { get; set; }
        public virtual SOLICITUD_ESTADOS SOLICITUD_ESTADOS { get; set; }
        public virtual SOLICITUD_TIPOS SOLICITUD_TIPOS { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
        public virtual USUARIOS USUARIOS1 { get; set; }
    }
}