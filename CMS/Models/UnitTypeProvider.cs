using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMS.Models
{
    public class UnitTypeProvider : IProvider<UnitType>
    {
        private CargoDBEntities db = new CargoDBEntities();
        public int Delete(UnitType t)
        {
            if (t == null) return 0;
            var model = db.UnitType.ToList().FirstOrDefault(item => t.Id == item.Id);
            if (model == null) return 0;
            db.UnitType.Remove(model);

            int count = db.SaveChanges();
            return count;
        }

        public int Insert(UnitType t)
        {
            if (t == null) return 0;
            if(string.IsNullOrEmpty(t.Name) || string.IsNullOrEmpty(t.MemberName)) return 0;
            if(t.InsertDate == null) return 0;
            db.UnitType.Add(t);
            int count = db.SaveChanges();
            return count;
        }

        public List<UnitType> Select()
        {
            return db.UnitType.ToList();
        }

        public int Update(UnitType t)
        {
            throw new NotImplementedException();
        }
    }
}
