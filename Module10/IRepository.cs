using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetItemsList();
        T GetItem(int id);
        public void Create(T item);
        public void Delete(int id);
    }
}
