using MarnieWcf.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MarnieWcf.DbAccess
{
    public class DbPerson : DBInterface<Person>
    {
        public void Delete(int id)
        {
            using(var db = new MyDbContext())
            {
                var person = new Person { PersonId = id };
                db.Persons.Attach(person);
                db.Persons.Remove(person);
                db.SaveChanges();
            }
        }

        public Person Get(int id)
        {
            using (var db = new MyDbContext())
            {
                return db.Persons.Find(id);
            }
        }

        public ICollection<Person> GetAll()
        {
            using (var db = new MyDbContext())
            {
                return db.Persons.ToList();               
            }
        }

        public ICollection<Person> GetAllWithRelations()
        {
            using (var db = new MyDbContext())
            {
                return db.Persons.Include(p => p.Dates).Include(p => p.Posts).ToList();
            }
        }

        public Person GetWithRelations(int id)
        {
            using (var db = new MyDbContext())
            {
                return db.Persons.Where(p => p.PersonId == id).Include(p => p.Dates).Include(p => p.Posts).FirstOrDefault();
            }
        }

        public void Insert(Person item)
        {
            using (var db = new MyDbContext())
            {
                db.Persons.Add(item);
                db.SaveChanges();
            }
        }

        public void Update(Person item)
        {
            using (var db = new MyDbContext())
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}