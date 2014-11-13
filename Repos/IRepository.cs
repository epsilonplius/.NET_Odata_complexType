using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repos
{
	public interface IRepository<T> where T:class
	{
		IQueryable<T> ItemSet { get; }

		T List();

		T Add();

		T Create();

		T Update(T entity);

		T Delete(T entity);
	}
}
