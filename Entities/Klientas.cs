using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Klientas
	{
		public int Id { get; set; }
		public string Pavadinimas { get; set; }
		public string ImonesKodas { get; set; }

		public Adresas Adresas { get; set; }
	}
}
