using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another.Model
{
    class Workout
    {
        public Workout() { }

        public Workout(string workId, string name, string date, string time, string length, string level)
        {
            WorkId = workId;
            Name = name;
            Date = date;
            Time = time;
            Length = length;

        }

        private string workId;
        public string WorkId
        {
            get { return workId; }
            set { workId = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        private string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private string length;
        public string Length
        {
            get { return length; }
            set { length = value; }
        }

        private string level;
        public string Level
        {
            get { return level; }
            set { level = value; }
        }
    }
}
