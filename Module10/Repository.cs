using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Repository<T> : IRepository<T>
        where T : Book
    {
        private List<T> list { get; set; } = new List<T>();

        public IEnumerable<T> GetItemsList() => list;

        public T GetItem(int id) => list.Find(x => x.Id == id);

        public void Create(T item) => list.Add(item);

        public void Delete(int id) => list.Remove(GetItem(id));
    }
}
