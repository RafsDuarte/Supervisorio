//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supervisorio.Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class PESAGEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PESAGEM()
        {
            this.DESTINO = new HashSet<DESTINO>();
        }
    
        public int ID { get; set; }
        public int IDCaminhao { get; set; }
        public double Peso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DESTINO> DESTINO { get; set; }
        public virtual FROTA FROTA { get; set; }
    }
}