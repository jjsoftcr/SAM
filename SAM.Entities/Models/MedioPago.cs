//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAM.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedioPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedioPago()
        {
            this.TrabajoPago = new HashSet<TrabajoPago>();
        }
    
        public int id_taller { get; set; }
        public int id_medioPago { get; set; }
        public string nombre { get; set; }
    
        public virtual Taller Taller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrabajoPago> TrabajoPago { get; set; }
    }
}
