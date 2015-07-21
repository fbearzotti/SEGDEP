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
    
    public partial class personas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public personas()
        {
            this.asistenciaEntrenamientos = new HashSet<asistenciaEntrenamientos>();
            this.categoriasPersonas = new HashSet<categoriasPersonas>();
            this.destrezasPersonas = new HashSet<destrezasPersonas>();
            this.eventos = new HashSet<eventos>();
            this.medidas = new HashSet<medidas>();
            this.pagos = new HashSet<pagos>();
            this.posicionesPersonas = new HashSet<posicionesPersonas>();
        }
    
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<System.DateTimeOffset> fecnac { get; set; }
        public Nullable<int> idTipoDocumento { get; set; }
        public Nullable<long> documento { get; set; }
        public string celular { get; set; }
        public string nota { get; set; }
        public Nullable<int> idTipoPersona { get; set; }
        public string calle { get; set; }
        public Nullable<int> numero { get; set; }
        public string piso { get; set; }
        public string depto { get; set; }
        public Nullable<int> codpos { get; set; }
        public Nullable<int> idLocalidad { get; set; }
        public string comollegar { get; set; }
        public string email { get; set; }
        public string facebook { get; set; }
        public string telefono { get; set; }
        public string activo { get; set; }
        public Nullable<int> idClub { get; set; }
        public byte[] foto { get; set; }
        public Nullable<int> idusuariomod { get; set; }
        public Nullable<System.DateTimeOffset> fechamod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<asistenciaEntrenamientos> asistenciaEntrenamientos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<categoriasPersonas> categoriasPersonas { get; set; }
        public virtual clubes clubes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<destrezasPersonas> destrezasPersonas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eventos> eventos { get; set; }
        public virtual localidades localidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<medidas> medidas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pagos> pagos { get; set; }
        public virtual tipoPersonas tipoPersonas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<posicionesPersonas> posicionesPersonas { get; set; }
        public virtual tipoDocumentos tipoDocumentos { get; set; }
    }
}