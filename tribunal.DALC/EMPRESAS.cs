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
    
    public partial class EMPRESAS
    {
        public EMPRESAS()
        {
            this.CONTRATOS_CLIENTES = new HashSet<CONTRATOS_CLIENTES>();
            this.USUARIOS = new HashSet<USUARIOS>();
        }
    
        public decimal ID_EMPRESA { get; set; }
        public string NOMBRE { get; set; }
        public string RAZON_SOCIAL { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<int> TELEFONO { get; set; }
        public System.DateTime CREADO { get; set; }
        public Nullable<System.DateTime> MODIFICADO { get; set; }
        public Nullable<decimal> ID_COMUNA { get; set; }
    
        public virtual COMUNA COMUNA { get; set; }
        public virtual ICollection<CONTRATOS_CLIENTES> CONTRATOS_CLIENTES { get; set; }
        public virtual ICollection<USUARIOS> USUARIOS { get; set; }
    }
}
