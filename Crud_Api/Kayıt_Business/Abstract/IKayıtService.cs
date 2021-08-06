using Kayıt_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kayıt_Business.Abstract
{
    public interface IKayıtService 
    {
        List<Kayıt> GetAllKayıt();

        Kayıt GetKayıtById(int id);

        Kayıt CreateKayıt(Kayıt kayıt);

        void  DeleteKayıt(int id);

        Kayıt UpdateKayıt(Kayıt kayıt);
    }

}
