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
    
    public partial class Factura_lin
    {
        public int Id_factura_lin { get; set; }
        public Nullable<int> Id_producto { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public int Id_Factura_Cab { get; set; }
        public System.DateTime Fecha_insert { get; set; }
    
        public virtual Factura_cab Factura_cab { get; set; }
        public virtual Producto Producto { get; set; }
    }
}