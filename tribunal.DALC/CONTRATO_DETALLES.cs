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
    
    public partial class CONTRATO_DETALLES
    {
        public CONTRATO_DETALLES()
        {
            this.CONTRATOS = new HashSet<CONTRATOS>();
        }
    
        public decimal ID_DETALLE_CONTRATO { get; set; }
        public string SERVICIO { get; set; }
        public long MONTO { get; set; }
    
        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }
    }
}
