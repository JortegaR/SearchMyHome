//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SearchMyHome.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class EstadoSuscripcion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstadoSuscripcion()
        {
            this.TipoSuscripcionSuscriptor = new HashSet<TipoSuscripcionSuscriptor>();
        }
    
        public int estadoSuscripcionId { get; set; }
        public string estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoSuscripcionSuscriptor> TipoSuscripcionSuscriptor { get; set; }
    }
}
