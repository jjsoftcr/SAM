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
    
    public partial class Externo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Externo()
        {
            this.TrabajoExterno = new HashSet<TrabajoExterno>();
        }
    
        public int id_taller { get; set; }
        public string id_externo { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public string detalle { get; set; }
    
        public virtual Taller Taller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrabajoExterno> TrabajoExterno { get; set; }
    }
}