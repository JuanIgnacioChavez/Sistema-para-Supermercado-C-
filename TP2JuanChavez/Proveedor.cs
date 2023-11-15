using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2JuanChavez
{
	public class Proveedor
	{
		public int ProveedorID { get; set; }
		public string Nombre { get; set; }
		public string Rubro { get; set; }
		public string Celular { get; set; }
		public string Email { get; set; }

		public Proveedor(int proveedorID, string nombre, string rubro, string celular, string email)
		{
			ProveedorID = proveedorID;
			Nombre = nombre;
			Rubro = rubro;
			Celular = celular;
			Email = email;
		}
	}
}
