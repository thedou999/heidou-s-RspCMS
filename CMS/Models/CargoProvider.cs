using CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Models
{
    public class CargoProvider : IProvider<Cargo>
    {
        private CargoDBEntities db = new CargoDBEntities();
        public int Delete(Cargo t)
        {
            if (t == null) return 0;
            var cargo = db.Cargo.ToList().FirstOrDefault(item => 
            {
                return item.Id == t.Id;
            });
            if (cargo == null) return 0;
            else
            {
                db.Cargo.Remove(cargo);
                return db.SaveChanges();
            }

        }

        public int Insert(Cargo t)
        {
            if (t == null) return 0;
            if(string.IsNullOrEmpty(t.Name))return 0;
            if(string.IsNullOrEmpty(t.TypeId.ToString()))return 0;
            if(string.IsNullOrEmpty(t.UnitName))return 0;
            if(string.IsNullOrEmpty(t.UnitId.ToString()))return 0;
            if(string.IsNullOrEmpty(t.Price.ToString()))return 0;
            if(t.InsertDate == null)return 0;
            if(string.IsNullOrEmpty(t.MemberId.ToString()))return 0;
            if(string.IsNullOrEmpty(t.MemberName))return 0;

            db.Cargo.Add(t);
            var count = db.SaveChanges();
            return count;

        }

        public List<Cargo> Select()
        {
            return db.Cargo.ToList();
        }

        public int Update(Cargo t)
        {
            if (t == null) return 0;
            var cargo = db.Cargo.ToList().FirstOrDefault(item => 
            {
                return item.Id == t.Id;
            });
            if (cargo == null) return 0;
            else
            {
                cargo.TypeName = t.TypeName;
                cargo.TypeId = t.TypeId;
                cargo.Number = t.Number;
                cargo.UnitName = t.UnitName;
                cargo.Price = t.Price;
                cargo.Tag = t.Tag;
                return db.SaveChanges();
            }
        }
    }
}
