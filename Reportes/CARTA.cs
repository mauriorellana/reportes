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
    
    public partial class CARTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CARTA()
        {
            this.RESTAURANTE1 = new HashSet<RESTAURANTE>();
        }
    
        public string ID_CARTA { get; set; }
        public string ID_RESTAURANTE { get; set; }
        public string ID_PLATO { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual PLATO PLATO { get; set; }
        public virtual RESTAURANTE RESTAURANTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESTAURANTE> RESTAURANTE1 { get; set; }
    }
}
