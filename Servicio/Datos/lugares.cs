//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicio.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class lugares
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lugares()
        {
            this.eventos = new HashSet<eventos>();
        }
    
        public int ID { get; set; }
        public string deno { get; set; }
        public string coordenada { get; set; }
        public Nullable<int> idusuariomod { get; set; }
        public Nullable<System.DateTimeOffset> fechamod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eventos> eventos { get; set; }
    }
}
