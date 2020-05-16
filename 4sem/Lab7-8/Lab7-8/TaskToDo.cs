using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_8
{
    public class TaskProperties
    {
        public List<String> priority = new List<String> { "super important", "important", "can wait", "insignificant" };
        public List<String> frequency = new List<String> { "once", "daily", "weekly", "monthly", "annually"};
        public List<String> status = new List<String> { "undone", "done", "delayed"};
        public List<String> cathegory = new List<string> { "JOB", "HEALTH", "HOME", "STUDY", "RELAX", "OTHER"};
    }

    [Serializable]
    public class TaskToDo
    {
        public String Task { get; set; }
        public String Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        //-----------------------
        public String priority { get; set; }
        public String frequency { get; set; }
        public String status { get; set; }
        public String cathegory { get; set; }

        public TaskToDo()
        {
            this.Task = "";
            this.Description = "";
            this.Start = DateTime.Now;
            this.End = DateTime.Now;
            this.priority = (new TaskProperties()).priority[3];
            this.frequency = (new TaskProperties()).frequency[0];
            this.status = (new TaskProperties()).status[0];
            this.cathegory = (new TaskProperties()).cathegory[5];
        }

        public TaskToDo(string task, string description, DateTime start, DateTime end, 
            string priority, string frequency, string status, string cathegory)
        {
            Task = task;
            Description = description;
            Start = start;
            End = end;
            this.priority = priority;
            this.frequency = frequency;
            this.status = status;
            this.cathegory = cathegory;
        }

        public override string ToString()
        {
            return this.priority + '\n' + this.cathegory + '\n' + this.Task + '\n' +
                this.Start.ToLongDateString() + " - " + this.End.ToLongDateString() + '\n' +
                "repeat: " + this.frequency + '\n' +
                "status: " + this.status;
        }
    }
}
