using MarnieWcf.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MarnieWcf.DbAccess
{
    public class DbPost : DBInterface<Post>
    {
        public void Delete(int id)
        {
            using (var db = new MyDbContext())
            {
                var post = new Post { PostId = id };
                db.Posts.Attach(post);
                db.Posts.Remove(post);
                db.SaveChanges();
            }
        }

        public ICollection<Post> GetAllWithRelations()
        {
            using (var db = new MyDbContext())
            {
                return db.Posts.Include(p => p.Person).ToList();
            }
        }

        public Post GetWithRelations(int id)
        {
            using (var db = new MyDbContext())
            {
                return db.Posts.Where(p => p.PostId == id).Include(p => p.Person).FirstOrDefault();
            }
        }

        public void Insert(Post item)
        {
            using (var db = new MyDbContext())
            {
                db.Posts.Add(item);
                db.SaveChanges();
            }
        }

        public void Update(Post item)
        {
            using (var db = new MyDbContext())
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
