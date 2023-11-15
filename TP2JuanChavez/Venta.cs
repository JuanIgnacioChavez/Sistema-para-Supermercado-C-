using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2JuanChavez
{
	public class Venta
	{
		public int VentaID { get; set; }
		public decimal Monto { get; set; }
		public DateTime Fecha { get; set; }
		public int NumeroSerie { get; set; }
		public int NumeroVenta { get; set; }

		public Venta()
		{
		}
	}
}
