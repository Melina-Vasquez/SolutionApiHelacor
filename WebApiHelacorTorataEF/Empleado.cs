//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiHelacorTorataEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Producto = new HashSet<Producto>();
        }
    
        public int Idempleado { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string I_Identidad { get; set; }
        public string Tipo_I_Identidad { get; set; }
        public Nullable<int> Telefono { get; set; }
        public string Domiclio { get; set; }
        public int Idpuesto { get; set; }
        public Nullable<System.DateTime> Fecha_Alta { get; set; }
        public Nullable<System.DateTime> Fecha_Operacion { get; set; }
        public string Descripcion_Operacion { get; set; }
        public Nullable<decimal> Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
        public virtual Puesto Puesto { get; set; }
    }
}
