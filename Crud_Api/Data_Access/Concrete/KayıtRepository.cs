using Data_Access.Abstract;
using Kayıt_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete
{
    public class KayıtRepository : IKayıtRepository
    {
        public Kayıt CreateKayıt(Kayıt kayıt)
        {
            using (var KayıtDbContext = new KayıtDbContext())
            {
               KayıtDbContext.Kayıts.Add(kayıt);
               KayıtDbContext.SaveChanges();
                return kayıt;
            }
        }

        public void DeleteKayıt(int id)
        {
            using (var KayıtDbContext = new KayıtDbContext())
            {
                var deleteKayıt = GetKayıtById(id);
                KayıtDbContext.Kayıts.Remove(deleteKayıt);
                KayıtDbContext.SaveChanges();
            }
        }

        public List<Kayıt> GetAllKayıts()
        {
            using (var KayıtDbContext = new KayıtDbContext())
            {
                return KayıtDbContext.Kayıts.ToList();
            }
        }

        public Kayıt GetKayıtById(int id)
        {
            using (var KayıtDbContext = new KayıtDbContext())
            {
                return KayıtDbContext.Kayıts.Find(id);
            }
        }

        public Kayıt UpdateKayıt(Kayıt kayıt)
        {
            using (var KayıtDbContext = new KayıtDbContext())
            {
                KayıtDbContext.Kayıts.Update(kayıt);
                KayıtDbContext.SaveChanges();
                return kayıt;
            }
        }
    }
}
