using System;
using System.Collections.Generic;

namespace MarnieWcf.Models
{
    public class Date
    {
        public int DateId { get; set; }
        public int TrainId { get; set; }
        public string DateStartLocation { get; set; }
        public string DateDistination { get; set; }
        public DateTime DateDate { get; set; }
        public List<Person> Persons { get; set; } = new List<Person>();

        public Date()
        {

        }

        public Date(int trainId, string dateStartLocation, string dateDistination, DateTime dateDate)
        {
            TrainId = trainId;
            DateStartLocation = dateStartLocation;
            DateDistination = dateDistination;
            DateDate = dateDate;
        }
    }
}
