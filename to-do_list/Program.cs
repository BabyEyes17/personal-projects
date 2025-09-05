namespace to_do_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager TM = new TaskManager(16);

            TM.createTask("Math Homework", "Finish chapter 5 problems", "2025-09-05");
            TM.createTask("CS Project", "Implement login feature", "2025-09-08");
            TM.createTask("Groceries", "Buy milk, eggs, and bread", "2025-09-01");
            TM.createTask("Laundry", "Wash and fold clothes", "2025-09-02");
            TM.createTask("Doctor Appointment", "Annual checkup", "2025-09-10");
            TM.createTask("Read Book", "Read 30 pages of 'Clean Code'", "2025-09-04");
            TM.createTask("Workout", "Gym session - legs day", "2025-09-03");
            TM.createTask("Call Mom", "Check in with family", "2025-09-06");

            Console.WriteLine(TM.displayAllTasks());

            TM.deleteTask(1);
            TM.deleteTask(3);
            TM.deleteTask(5);
            TM.deleteTask(32);

            Console.WriteLine(TM.displayAllTasks());
        }
    }
}
