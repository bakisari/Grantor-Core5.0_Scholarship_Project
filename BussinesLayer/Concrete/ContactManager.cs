using BussinesLayer.Abstract;
using DataAcessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact t)
        {
            _contactDal.Insert(t);
        }

        public List<Contact> AllList()
        {
            return _contactDal.GetListAll();
        }

        public void Delete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact GetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public void Update(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
