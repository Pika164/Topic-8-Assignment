namespace Topic_8_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Programing assignment task 1 - Reading in colors
            //List<String> colors = new List<String>();
            Random generator = new Random();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Please enter a color: ");
            //    colors.Add(Console.ReadLine());
            //}

            //Console.WriteLine();

            //Console.WriteLine(colors[generator.Next(colors.Count)]);

            //Console.WriteLine();

            //Console.WriteLine(string.Join(", ", colors));

            //Console.WriteLine();
            //Console.WriteLine("Press ENTER to continue");
            //Console.ReadLine();
            //Console.Clear();

            //Programing assignment task 2 - Random Numbers
            List<int> numbers = new List<int>();
            int numAmount, maxValue, minValue, number, number2, count;

            count = 0;

            Console.Write("How many numbers do you need?: ");
            numAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a maximum value: ");
            maxValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please eneter a Minimum value: ");
            minValue = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            for (int i = 0; i < numAmount; i++)
            {
                numbers.Add(generator.Next(minValue, maxValue + 1));
            }
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.Write("Enter a number from the list shown above: ");
            number = Convert.ToInt32(Console.ReadLine());
            numbers.Remove(number);
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", numbers));
            Console.Clear();
            numbers.Add(number);
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.Write("Enter a number from the list: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number2)
                {
                    numbers.RemoveAll(numbers2);
                }
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", numbers));
            Console.ReadLine();
        }
    }
}
