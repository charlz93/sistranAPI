//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaOnline.DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Factura_lin = new HashSet<Factura_lin>();
        }
    
        public int Id_producto { get; set; }
        public Nullable<int> cantidad { get; set; }
        public string Nombre_producto { get; set; }
        public Nullable<int> Id_categoria { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> Id_promo { get; set; }
        public string Imagen { get; set; }
        public Nullable<int> Id_estado { get; set; }
        public string Descripcion { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura_lin> Factura_lin { get; set; }
        public virtual Promocione Promocione { get; set; }
    }
}
