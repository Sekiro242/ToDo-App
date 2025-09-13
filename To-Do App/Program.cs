namespace To_Do_App
{
    class TaskItem
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<TaskItem> tasks = new List<TaskItem>();
            tasks.Add(new TaskItem { ID = 1, Description = "Sample Task", IsDone = false });
            tasks.Add(new TaskItem { ID = 2, Description = "Another Task", IsDone = true });
            while (true)
            {
                Console.WriteLine("1. Add a Task");
                Console.WriteLine("2. List All Tasks");
                Console.WriteLine("3. Mark Task As Done");
                Console.WriteLine("4. Exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Enter The Task Name: ");
                        string taskName = Console.ReadLine();
                        int newID = tasks.Count + 1;

                        tasks.Add(new TaskItem { ID = newID, Description = taskName, IsDone = false });
                        Console.WriteLine("Task Added Successfully!");
                        break;

                    case "2":



                        foreach (var task in tasks)
                        {
                            string status = task.IsDone ? "Done" : "Pending";
                            Console.WriteLine($"{task.ID}. {task.Description} - {status}");
                        }

                        break;


                        case "3":
                        Console.WriteLine("Enter The Task ID To Mark As Done: ");
                        int taskId = int.Parse(Console.ReadLine());
                        var taskToMark = tasks.FirstOrDefault(t => t.ID == taskId);
                        if (taskToMark != null)
                        {
                            taskToMark.IsDone = true;
                            Console.WriteLine("Task Marked As Done Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Task not found.");
                        }

                   
                        break;
                        case "4":
                        return;
                        default:
                        Console.WriteLine("Invalid Option. Please Try Again.");
                        break;

                }



            }
        }
    }
}
