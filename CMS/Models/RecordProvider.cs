using CMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RecordProvider : IProvider<Record>
    {
        private CargoDBEntities db = new CargoDBEntities();
        public int Delete(Record t)
        {
            if (t == null) return 0;
            if(!(t is Record record)) return 0;
            if(string.IsNullOrEmpty(record.CargoName)) return 0;
            var model = db.Record.FirstOrDefault<Record>( item => item.Id == record.Id);
            if(model == null) return 0;

            db.Record.Remove(model);
            return db.SaveChanges();

        }

        public int Insert(Record t)
        {
            if (t == null) return 0;
            if (!(t is Record record)) return 0;
            if(string.IsNullOrEmpty(record.CargoName)) return 0;
            db.Record.Add(record);

            var cargoModel = db.Cargo.FirstOrDefault<Cargo>( item=> item.Id == record.CargoId);
            if(record.InOrOutBit == true)
            {
                cargoModel.Number += int.Parse(record.Number.ToString());
            }
            else cargoModel.Number -= int.Parse(record.Number.ToString());

            return db.SaveChanges();


        }

        public List<Record> Select()
        {
            return db.Record.ToList();
        }

        public int Update(Record t)
        {
            if (t == null) return 0;
            return 0;
        }
    }
}
