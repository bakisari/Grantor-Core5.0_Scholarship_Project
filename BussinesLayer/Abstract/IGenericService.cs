using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> AllList();
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        T GetByID(int id);
    }
}
