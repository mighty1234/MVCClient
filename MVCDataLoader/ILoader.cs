using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDataLoader
{
    interface ILoader<T> where T:class
    {
        List<T> GetAll();
        T GetInsertedById(int id);
        T GetById(int id);
        void Save(T Entity);
        void Delete(int id);
    }
}
