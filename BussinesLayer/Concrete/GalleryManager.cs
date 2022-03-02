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
    public class GalleryManager : IGalleryService
    {
        IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public void Add(Gallery t)
        {
            throw new NotImplementedException();
        }

        public List<Gallery> AllList()
        {
            return _galleryDal.GetListAll();   
        }

        public void Delete(Gallery t)
        {
            throw new NotImplementedException();
        }

        public Gallery GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Gallery t)
        {
            throw new NotImplementedException();
        }
    }
}
