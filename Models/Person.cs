using System;
using System.Collections.Generic;

namespace MarnieWcf.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Sex { get; set; }
        public string ProfilPicture { get; set; }        
        public List<Date> Dates { get; set; } = new List<Date>();
        public List<Post> Posts { get; set; } = new List<Post>();

        public Person()
        {

        }

        public Person(string name, DateTime birthday, string sex, string profilPicture)
        {            
            Name = name;
            Birthday = birthday;
            Sex = sex;
            ProfilPicture = profilPicture;
        }
    }
}