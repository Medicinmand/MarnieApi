
using MarnieWcf.Models;
using System;

namespace MarnieWcf.DbAccess
{
    public class GenerateData
    {
        public GenerateData()
        {
            var p1 = new Person("Lars", DateTime.Parse("05/06/1963"), "Male", "hotPicture");
            var p2 = new Person("Jens", DateTime.Parse("02/04/1977"), "Male", "path");
            var p3 = new Person("Tina", DateTime.Now, "Female", "picture");
            var p4 = new Person("Christi", DateTime.Parse("01/01/1980"), "Female", "path");

            var post1 = new Post(1, "Aal", "KBH", DateTime.Parse("06/06/2017"), 1, 1, p1);
            var date1 = new Date(1, "Aal", "KBH", DateTime.Parse("06/06/2017"));
            p1.Dates.Add(date1);
            p1.Posts.Add(post1);
            p3.Dates.Add(date1);

            var db = new DbPerson();
            db.Insert(p1);
            db.Insert(p2);
            db.Insert(p3);
            db.Insert(p4);
        }
    }
}