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
    
    public partial class entrenamientos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public entrenamientos()
        {
            this.asistenciaEntrenamientos = new HashSet<asistenciaEntrenamientos>();
        }
    
        public int ID { get; set; }
        public System.DateTime fecha { get; set; }
        public int idCategoria { get; set; }
        public int idClima { get; set; }
        public int idEstadoCampo { get; set; }
        public int idTipoSesion { get; set; }
        public string notas { get; set; }
        public Nullable<int> idusuariomod { get; set; }
        public Nullable<System.DateTimeOffset> fechamod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<asistenciaEntrenamientos> asistenciaEntrenamientos { get; set; }
        public virtual categorias categorias { get; set; }
        public virtual climas climas { get; set; }
        public virtual tipoSesion tipoSesion { get; set; }
        public virtual estadoCampos estadoCampos { get; set; }
    }
}