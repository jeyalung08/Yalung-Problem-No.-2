namespace Yalung_Problem_No._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an the amount you to process: ");
            int count = int.Parse(Console.ReadLine());                      //kunin yung range 

            int[] numbers = new int[count];                                  //create the array 

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());                 //Loop para sa inputs
            }

            int sum = 0;
            int smallest = numbers[0];
            int largest = numbers[0];

            foreach (int num in numbers)
            {
                sum += num;                                                 //add function
                if (num < smallest) smallest = num;                         //checks if yun ba yung smallest number
                if (num > largest) largest = num;                           //checks if yun yung largest number
            }

            Console.WriteLine($"Sum of all numbers: {sum}");                //prints the sum
            Console.WriteLine($"Smallest number: {smallest}");              //prints the smallest int
            Console.WriteLine($"Largest number: {largest}");                //prints the largest int
        }
    }
}
