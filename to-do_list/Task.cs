using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do_list
{
    internal class Task
    {
        private int id;
        private string name;
        private string description;
        private string dueDate;

        public Task(string name, string description, string dueDate)
        {
            this.name = name;
            this.description = description;
            this.dueDate = dueDate;
        }

        /* Getters */
        public int getId() { return id; }
        public string getName() { return name; }
        public string getDescription() { return description; }
        public string getDueDate() { return dueDate; }

        /* Setters */
        public void setId(int id) { this.id = id; }
        public void setName(string name) { this.name = name; }
        public void setDescription(string description) { this.description = description; }
        public void setDueDate(string dueDate) { this.dueDate = dueDate; }


        public string displayTask()
        {

            string s = "\n" + name.ToString() + "\n";
            s += new string('-', name.Length) + "\n";
            s += "ID: " + this.getId() + "\n";
            s += "Description: " + description.ToString() + "\n";
            s += "Due: " + dueDate.ToString() + "\n";

            return s;
        }
    }
}
