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
    
    public partial class TRIBUNAL
    {
        public TRIBUNAL()
        {
            this.CAUSAS = new HashSet<CAUSAS>();
        }
    
        public decimal ID_TRIBUNAL { get; set; }
        public string NOMBRE { get; set; }
        public decimal ID_COMUNA { get; set; }
    
        public virtual ICollection<CAUSAS> CAUSAS { get; set; }
        public virtual COMUNA COMUNA { get; set; }
    }
}
