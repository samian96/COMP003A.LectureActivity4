namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = 1;

            Console.WriteLine("Section A: While Loop Practice:");

            Console.WriteLine("\n");
            // while loop going through numbers 1 to 5 to display task that has been completed
            while (taskNumber <= 5)
            {
                Console.WriteLine($"Task {taskNumber} completed");
                taskNumber++; // increases int by 1
            }

            Console.WriteLine("\n");

            Console.WriteLine("Section B: Do-while Loop Practrice:");

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

            Console.WriteLine("Section C: for Loop Practice:");

            Console.WriteLine("\n");
            // for loops are great for tasks that require a known number of repititions, instead of condition like a while loop
            for (int x = 1; x <= 5; x++)
            {
                Console.WriteLine($"Step {x}");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Section D: Loop Control 'break' and 'continue':");

            Console.WriteLine("\n");
            /* when int number was set to 1 it would skip and go straight to 2
             Not sure if problem in my logic please let me know*/
            int number = 0;

            while (number <= 6)
            {
                number++;

                if (number == 4)
                {
                    continue;
                }
                if (number == 6)
                {
                    break;
                }
                Console.WriteLine(number);
            }
        }
    }
}
