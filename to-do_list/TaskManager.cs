using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace to_do_list
{
    internal class TaskManager
    {
        private static int idCounter = 1;
        private int numTasks;
        private int maxTasks;
        private Task[] tasks;

        public TaskManager(int maxTasks)
        {
            this.maxTasks  = maxTasks;
            tasks = new Task[maxTasks];
            numTasks = 0;
        }

        public int getNumTasks() { return numTasks; }



        public void createTask(string name, string description, string dueDate)
        {
            if (numTasks >= maxTasks)
            {
                Console.WriteLine("Task list is full. Cannot add more tasks.");
                return;
            }

            Task newTask = new Task(name, description, dueDate);
            newTask.setId(idCounter);

            tasks[numTasks] = newTask;

            numTasks++;
            idCounter++;
            
            Console.WriteLine($"Task successfully created.");
        }



        public void deleteTask(int id)
        {
            int index = findTaskById(id);

            if (index == -1)
            {
                Console.WriteLine($"Task with id {id} not found.");
                return;
            }

            for (int i = index; i < numTasks - 1; i++)
            {
                tasks[i] = tasks[i + 1];
            }

            tasks[numTasks - 1] = null;
            numTasks--;

            Console.WriteLine($"Task with id {id} successfully deleted.");
        }



        public int findTaskById(int id)
        {

            for (int i = 0; i < getNumTasks(); i++)
            {
                if (tasks[i].getId() == id)
                {
                    return i;
                }
            }

            return -1;
        }

        public string displayAllTasks()
        {
            string s = "Task List" + "\n";
            s += "Number of tasks: " + numTasks + "\n";
            s += "--------------------" + "\n";
            
            for (int i = 0; i < numTasks; i++)
            {
                s += tasks[i].displayTask();
            }

            return s;
        }
    }
}
