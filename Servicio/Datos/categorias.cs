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
    
    public partial class categorias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public categorias()
        {
            this.categoriasPersonas = new HashSet<categoriasPersonas>();
            this.destrezasPersonas = new HashSet<destrezasPersonas>();
            this.eventos = new HashSet<eventos>();
            this.salud = new HashSet<salud>();
            this.partidos = new HashSet<partidos>();
            this.entrenamientos = new HashSet<entrenamientos>();
            this.jugadores = new HashSet<jugadores>();
        }
    
        public int ID { get; set; }
        public string deno { get; set; }
        public string nombre { get; set; }
        public System.DateTimeOffset fechaalta { get; set; }
        public int idEntrenador { get; set; }
        public int idTemporada { get; set; }
        public Nullable<int> idNivelDestreza { get; set; }
        public Nullable<int> idusuariomod { get; set; }
        public Nullable<System.DateTimeOffset> fechamod { get; set; }
    
        public virtual destrezasNiveles destrezasNiveles { get; set; }
        public virtual temporadas temporadas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<categoriasPersonas> categoriasPersonas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<destrezasPersonas> destrezasPersonas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eventos> eventos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<salud> salud { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<partidos> partidos { get; set; }
        public virtual entrenadores entrenadores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entrenamientos> entrenamientos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jugadores> jugadores { get; set; }
    }
}