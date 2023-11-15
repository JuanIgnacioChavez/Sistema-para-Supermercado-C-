using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2JuanChavez
{
	public class Articulo
	{
		public string ArticuloID { get; set; }
		public string Detalle { get; set; }
		public string Presentacion { get; set; }
		public int PrecioCompra { get; set; }
		public int PrecioVenta { get; set; }
		public int Stock { get; set; }
		public string Proveedor { get; set; }
		public int Cantidad { get; set; }

		public Articulo(string articuloID, string detalle, int precioVenta, int cantidad)
		{
			ArticuloID = articuloID;
			Detalle = detalle;
			PrecioVenta = precioVenta;
			Cantidad = cantidad;
		}

		public Articulo(string articuloID, string detalle, int precioVenta)
		{
			ArticuloID = articuloID;
			Detalle = detalle;
			PrecioVenta = precioVenta;
		}

		public Articulo(string articuloID, string detalle, string presentacion, int precioCompra, int precioVenta, int stock, string proveedor)
		{
			ArticuloID = articuloID;
			Detalle = detalle;
			Presentacion = presentacion;
			PrecioCompra = precioCompra;
			PrecioVenta = precioVenta;
			Stock = stock;
			Proveedor = proveedor;
		}
	}
}
