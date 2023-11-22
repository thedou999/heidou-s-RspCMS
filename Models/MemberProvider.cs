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
            throw new NotImplementedException();
        }

        public int Insert(Member t)
        {
            throw new NotImplementedException();
        }

        public List<Member> Select()
        {
            return db.Member.ToList();
        }

        public int Update(Member t)
        {
            throw new NotImplementedException();
        }
    }
}
