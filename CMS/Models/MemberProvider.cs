using CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MemberProvider : IProvider<Member>
    {
        private CargoDBEntities db = new CargoDBEntities();

        public int Delete(Member t)
        {
            if (t == null) return 0;
            if(string.IsNullOrEmpty(t.Name)) return 0;
            var model = db.Member.FirstOrDefault<Member>(item => t.Name == item.Name);
            if (model == null) return 0;
            else db.Member.Remove(model);
            return db.SaveChanges();

        }

        public int Insert(Member t)
        {
            if (t == null) return 0;
            if(string.IsNullOrEmpty(t.Name)) return 0;
            if(string.IsNullOrEmpty(t.Password)) return 0;
            db.Member.Add(t);
            var count = db.SaveChanges();
            return count;
        }

        public List<Member> Select()
        {
            return db.Member.ToList();
        }

        public int Update(Member t)
        {
            if (t == null) return 0;
            if (string.IsNullOrEmpty(t.Name)) return 0;
            var model = db.Member.FirstOrDefault<Member>(item => t.Id == item.Id);
            if (model == null) return 0;
            else 
            {
                model.InsertDate = DateTime.Now;
                model.Password = t.Password;
                model.Name = t.Name;
                model.Role = t.Role;
                
                return db.SaveChanges();
            }


        }
    }
}
