using MarnieWcf.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MarnieWcf.DbAccess
{
    public class DbDate : DBInterface<Date>
    {
        public void Delete(int id)
        {
            using (var db = new MyDbContext())
            {
                var date = new Date { DateId = id };
                db.Dates.Attach(date);
                db.Dates.Remove(date);
                db.SaveChanges();
            }
        }

        public ICollection<Date> GetAllWithRelations()
        {
            using (var db = new MyDbContext())
            {
                return db.Dates.Include(p => p.Persons).ToList();
            }
        }

        public Date GetWithRelations(int id)
        {
            using (var db = new MyDbContext())
            {
                return db.Dates.Where(p => p.DateId == id).Include(p => p.Persons).FirstOrDefault();
            }
        }

        public void Insert(Date item)
        {
            using (var db = new MyDbContext())
            {
                db.Dates.Add(item);
                db.SaveChanges();
            }
        }

        public void Update(Date item)
        {
            using (var db = new MyDbContext())
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}