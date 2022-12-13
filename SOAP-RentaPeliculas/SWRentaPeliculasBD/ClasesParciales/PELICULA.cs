using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWRentaPeliculasBD
{
    public partial class PELICULA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PELICULA()
        {
            this.FICHARENTA = new List<FICHARENTA>();
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FICHARENTA> FICHARENTA { get; set; }
    }
}