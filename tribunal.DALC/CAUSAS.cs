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
    
    public partial class CAUSAS
    {
        public CAUSAS()
        {
            this.DILIGENCIAS = new HashSet<DILIGENCIAS>();
        }
    
        public decimal ID_CAUSA { get; set; }
        public string ROL { get; set; }
        public System.DateTime FECHA { get; set; }
        public string CARATULA { get; set; }
        public decimal ID_TRIBUNAL { get; set; }
    
        public virtual TRIBUNAL TRIBUNAL { get; set; }
        public virtual ICollection<DILIGENCIAS> DILIGENCIAS { get; set; }
    }
}
