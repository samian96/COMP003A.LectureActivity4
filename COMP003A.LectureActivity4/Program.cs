namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = 1;

            Console.WriteLine("Section A: While Loop Practice");

            Console.WriteLine("\n");
            // while loop going through numbers 1 to 5 to display task that has been completed
            while (taskNumber <= 5)
            {
                Console.WriteLine($"Task {taskNumber} completed");
                taskNumber++; // increases int by 1
            }

            Console.WriteLine("\n");

            Console.WriteLine("Section B: Do-while Loop Practrice");

            Console.WriteLine("\n");
            /*A do loop executes at least one or more times because
             the loop evaluates the expression after each execution*/
            int attempt = 1;

            do
            {
                Console.WriteLine($"Attempt {attempt} ");
                attempt++; 
            }
            while (attempt <= 3); // should exit loop once int is equal to 3

            Console.WriteLine("\n");

            Console.WriteLine("Section C: for Loop Practice");

            Console.WriteLine("\n");




        }
    }
}
