namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = 1;
            // while loop going through numbers 1 to 5 to display task that has been completed
            while (taskNumber <= 5)
            {
                Console.WriteLine($"Task {taskNumber} completed");
                taskNumber++;
            }
        }
    }
}
