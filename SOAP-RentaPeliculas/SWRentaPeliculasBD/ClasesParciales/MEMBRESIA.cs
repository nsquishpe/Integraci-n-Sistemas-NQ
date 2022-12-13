using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SWRentaPeliculasBD
{
    public partial class MEMBRESIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEMBRESIA()
        {
            this.CLIENTE = new HashSet<CLIENTE>();
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [XmlIgnore]
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }
        public virtual CLIENTE CLIENTE1 { get; set; }
    }
}