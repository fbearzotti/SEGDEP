//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RESTService.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class variables
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public variables()
        {
            this.eventos = new HashSet<eventos>();
            this.valores = new HashSet<valores>();
        }
    
        public int ID { get; set; }
        public string deno { get; set; }
        public Nullable<int> idusuariomod { get; set; }
        public Nullable<System.DateTimeOffset> fechamod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eventos> eventos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<valores> valores { get; set; }
    }
}
