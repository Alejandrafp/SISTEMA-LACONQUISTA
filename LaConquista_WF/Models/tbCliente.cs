//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaConquista_WF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbCliente()
        {
            this.tbEncabezadoFactura = new HashSet<tbEncabezadoFactura>();
        }
    
        public int clint_IdCliente { get; set; }
        public string clint_Nombre { get; set; }
        public string clint_Apellido { get; set; }
        public string clint_Identificacion { get; set; }
        public string clint_Telefono { get; set; }
        public string clint_Direccion { get; set; }
        public string clint_Correo { get; set; }
        public Nullable<bool> clint_Estado { get; set; }
        public int UsuarioCrea { get; set; }
        public System.DateTime FechaCrea { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEncabezadoFactura> tbEncabezadoFactura { get; set; }
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
    }
}
