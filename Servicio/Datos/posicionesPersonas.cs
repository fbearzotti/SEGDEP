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
    
    public partial class posicionesPersonas
    {
        public int ID { get; set; }
        public int idPersona { get; set; }
        public Nullable<int> idPosicion1 { get; set; }
        public Nullable<int> idPosicion2 { get; set; }
        public Nullable<int> idPosicion3 { get; set; }
        public Nullable<int> idTemporada { get; set; }
        public string nota { get; set; }
        public Nullable<int> idusuariomod { get; set; }
        public Nullable<System.DateTimeOffset> fechamod { get; set; }
    
        public virtual personas personas { get; set; }
        public virtual posiciones posiciones { get; set; }
        public virtual posiciones posiciones1 { get; set; }
        public virtual posiciones posiciones2 { get; set; }
        public virtual temporadas temporadas { get; set; }
    }
}
