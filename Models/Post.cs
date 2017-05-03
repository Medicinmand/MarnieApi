using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarnieWcf.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int TrainId { get; set; }
        public string StartLocation { get; set; }
        public string Distination { get; set; }
        public DateTime TravelDate { get; set; }
        public int Status { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; } = new Person();

        public Post()
        {

        }

        public Post(int trainId, string startLocation, string distination, DateTime travelDate, int status, int personId, Person person)
        {
            TrainId = trainId;
            StartLocation = startLocation;
            Distination = distination;
            TravelDate = travelDate;
            Status = status;
            PersonId = personId;
            Person = person;
        }
    }
}