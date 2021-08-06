using Kayıt_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Abstract
{
    public interface IKayıtRepository
    {
       List<Kayıt> GetAllKayıts();

       Kayıt GetKayıtById(int id);
       
       Kayıt CreateKayıt(Kayıt kayıt);
       
       Kayıt UpdateKayıt(Kayıt kayıt);
       
       void DeleteKayıt(int id);
    }
}
