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
    
    public partial class tipoDocumentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipoDocumentos()
        {
            this.personas = new HashSet<personas>();
        }
    
        public int ID { get; set; }
        public string deno { get; set; }
        public Nullable<int> idusuariomod { get; set; }
        public Nullable<System.DateTimeOffset> fechamod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personas> personas { get; set; }
    }
}
