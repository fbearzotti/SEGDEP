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
    
    public partial class saludenfermedades
    {
        public int ID { get; set; }
        public int idsalud { get; set; }
        public int idenfermedad { get; set; }
        public string nota { get; set; }
    
        public virtual enfermedades enfermedades { get; set; }
        public virtual salud salud { get; set; }
    }
}
