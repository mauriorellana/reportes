//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class PEDIDO_DE_VENTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PEDIDO_DE_VENTA()
        {
            this.RESTAURANTE = new HashSet<RESTAURANTE>();
        }
    
        public string ID_PEDIDO { get; set; }
        public string ID_DETALLEPEDIDO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<decimal> MONTOFINAL { get; set; }
    
        public virtual DETALLE_DE_PEDIDO DETALLE_DE_PEDIDO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESTAURANTE> RESTAURANTE { get; set; }
    }
}