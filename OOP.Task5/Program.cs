namespace OOP.Task5
{
    class Program : Task
    {

            static void Main(string[] args)
            {
                Task task = new Task();
                task.SetTasks();
                task.GetSumTimeOfTasks();
                task.GetTasksbyPriprity();
                task.GetTasksbyPriorityforDays();

            }

        
    }
}
