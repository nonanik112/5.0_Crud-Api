using Data_Access.Abstract;
using Data_Access.Concrete;
using Kayıt_Business.Abstract;
using Kayıt_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kayıt_Business.Concrete
{
    public class KayıtManager : IKayıtService
    {
        private IKayıtRepository _kayıtRepository;

        public KayıtManager(IKayıtRepository kayıtRepository)
        {
            _kayıtRepository = kayıtRepository;
        }
        public Kayıt CreateKayıt(Kayıt kayıt)
        {
            return _kayıtRepository.CreateKayıt(kayıt);
        }

        public void DeleteKayıt(int id)
        {
          _kayıtRepository.DeleteKayıt(id);
        }
        public List<Kayıt> GetAllKayıt()
        {
            return _kayıtRepository.GetAllKayıts();
        }

        public Kayıt GetKayıtById(int id)
        {
            if (id>0)
            {
                 return _kayıtRepository.GetKayıtById(id);
            }
            throw new Exception("id can not be less than one");
        }

        public Kayıt UpdateKayıt(Kayıt kayıt)
        {
            return _kayıtRepository.UpdateKayıt(kayıt);
        }
    }
}
