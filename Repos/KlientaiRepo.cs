using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repos
{
	public class KlientaiRepo:IRepository<Klientas>
	{
		public KlientaiRepo()
		{
			ItemSet = new List<Klientas>
			{
				new Klientas
				{
					Id = 1,
					Pavadinimas = "Klientas1",
					ImonesKodas = "12345",
					Adresas = new Adresas
					{
						Gatve = "Gatve",
						Miestas = "Miestas",
						Namas = "123b",
						PastoKodas = "LT-22222"
					}
				},
				new Klientas
				{
					Id = 2,
					Pavadinimas = "Klientas2",
					ImonesKodas = "23456",
					Adresas = new Adresas
					{
						Gatve = "Santariskiu",
						Miestas = "Vilnius",
						Namas = "2",
						PastoKodas = "LT-33333"
					}
				}
			}.AsQueryable();
		}
		public IQueryable<Klientas> ItemSet { get; private set; }
		public Klientas List()
		{
			throw new NotImplementedException();
		}

		public Klientas Add()
		{
			throw new NotImplementedException();
		}

		public Klientas Create()
		{
			throw new NotImplementedException();
		}

		public Klientas Update(Klientas entity)
		{
			throw new NotImplementedException();
		}

		public Klientas Delete(Klientas entity)
		{
			throw new NotImplementedException();
		}
	}
}
