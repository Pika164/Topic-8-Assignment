namespace Topic_8_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programing assignment task 1 - Reading in colors
            List<String> colors = new List<String>();
            Random generator = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please enter a color: ");
                colors.Add(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine(colors[generator.Next(colors.Count)]);

            Console.WriteLine();

            Console.WriteLine(string.Join(", ", colors));

            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //Programing assignment task 2 - Random Numbers
            List<int> numbers = new List<int>();
            int numAmount, maxValue, minValue, number, number2, count;

            count = 0;
            //Intro to assignment 2
            Console.WriteLine("This is the begining of the second task.");
            Console.WriteLine();
            Console.WriteLine("This part is where we get the numbers for the list.");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("How many numbers do you need?: ");
            numAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a maximum value: ");
            maxValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please eneter a Minimum value: ");
            minValue = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            //Step 1 and 2 Below
            Console.WriteLine("This is step 1 and 2.");
            Console.WriteLine();
            Console.WriteLine("This is where we print the list and ask the user for a number from the list.");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
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

            //Step 3 and 4 Below
            numbers.Add(number);
            
            Console.WriteLine("This is step 3 and 4.");
            Console.WriteLine();
            Console.WriteLine("This is where the user enters a number from the list and it gets removed from the list and it gets printed back out.");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.Write("Enter a number from the list: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number2)
                {
                    numbers[i]=0;
                }
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();

            //Step 5 and 6 Below
            Console.WriteLine("This is step 5 and 6.");
            Console.WriteLine();
            Console.WriteLine("This is where the list gets reset with all zeros and get printed back out.");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = 0;
            }
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //Step 7 and 8 below
            numbers.Clear();
            
            Console.WriteLine("These are the final steps, 7 and 8.");
            Console.WriteLine();
            Console.WriteLine("This is where the lists get random numbers to be put in the list and prints it back out.");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < numAmount; i++)
            {
                numbers.Add(generator.Next(minValue, maxValue + 1));
            }
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.WriteLine("Press Enter to stop the program");
            Console.ReadLine();
        }
    }
}
