
namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start point:");
            string start = Console.ReadLine();
            int startInt = Convert.ToInt32(start);
            Console.Write("Enter end point:");
            string end = Console.ReadLine();
            int endInt = Convert.ToInt32(end);

            if (endInt < startInt)
            {
                Console.WriteLine("Error: end point should be greater than start point.");
            }
            else 
            {
                int[] result = OneToTenWithInput(startInt, endInt);
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine(result[i]);
                }
            }
        }

        static int[] OneToTenWithInput(int start, int end)
        {
            int arraySize = end - start + 1;
            int counter = 0;
            int[] numsArray = new int[arraySize];
            for (int i = start; i <= end; i++) 
            {
                numsArray[counter] = i;
                counter++;
            }
            return numsArray;
        }
    }
}
