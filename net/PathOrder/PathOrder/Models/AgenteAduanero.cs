//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PathOrder.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AgenteAduanero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgenteAduanero()
        {
            this.OrdenDespacho = new HashSet<OrdenDespacho>();
        }
    
        public int IdAgenteAduanero { get; set; }
        public string Nombre { get; set; }
        public string RUC { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public bool PermisoAdmin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDespacho> OrdenDespacho { get; set; }
    }
}
