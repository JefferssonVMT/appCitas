//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CitasSalonApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fecha
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fecha()
        {
            this.DetalleFechaBloque = new HashSet<DetalleFechaBloque>();
        }
    
        public int Id { get; set; }
        public short año { get; set; }
        public short mes { get; set; }
        public short dia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFechaBloque> DetalleFechaBloque { get; set; }
    }
}
