// See https://aka.ms/new-console-template for more information

using System;
// using System.Linq;      // for min, max etc.

namespace ConsoleApp1
{
    class Program
    {
        static void WelcomeMessage(string name)
        {
            Console.WriteLine("Welcome, {0}", name);
        }
        static double Mean(double[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }

        static double Median(double[] nums)
        {
            Array.Sort(nums);
            double med;
            if (nums.Length % 2 != 0)
            {
                // length of array is odd
                int medianIndex = nums.Length / 2;
                med = nums[medianIndex];
            }
            else
            {
                // length of array is even
                int upperIndex = nums.Length / 2;
                int lowerIndex = upperIndex - 1;
                med = (nums[upperIndex] + nums[lowerIndex]) / 2;
            }
            return med;
        }

        static double Min(double[] nums)
        {
            double minValue = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < minValue)
                {
                    minValue = nums[i];
                }
            }
            return minValue;
        }
        
        static double Max(double[] nums)
        {
            double maxValue = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > maxValue)
                {
                    maxValue = nums[i];
                }
            }
            return maxValue;
        }

        static double Stdev(double[] nums)
        {
            double mean = Mean(nums);
            double sumSquareDiff = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                double squareDiff = Math.Pow(nums[i] - mean, 2);
                sumSquareDiff += squareDiff;
            }
            return Math.Sqrt(sumSquareDiff / nums.Length);
        }

        static double[] ConvertStringToArray(string numberString)
        {
            // define list for storing numbers, and an array for returning
            List<double> numbersList = new List<double>();

            while (numberString.Length > 0)
            {
                // find a comma
                int commaIndex = numberString.IndexOf(',');
                
                if (commaIndex >= 0)
                {
                    // Comma exists
                    // get number preceeding the next comma in the string
                    double nextNum = Convert.ToDouble(numberString.Substring(0, commaIndex));
                    // add the next number to the list
                    numbersList.Add(nextNum);
                    // get rid of that number and comma from the string
                    numberString = numberString.Substring(commaIndex+1);
                }
                else
                {
                    // Comma doesn't exist - we have reached the final number
                    // turn the rest of the string into a number
                    double nextNum = Convert.ToDouble(numberString);
                    // add next number to the list
                    numbersList.Add(nextNum);
                    // we have reached final number, so set string length to 0
                    numberString = "";
                }
            }
            // return the array
            double[] numbersArray = numbersList.ToArray();
            return numbersArray;
        }
        
        static void Main(string[] args)
        {
            // string name = "Sergei Meerkat";
            // WelcomeMessage(name);
            
            // defining some variables
            // int a = 1;
            // float price = 14.99f;
            // string name = "Laurie";
            // bool isOver10 = false;
            // Console.WriteLine("Good morning " + name);
            
            // type casting
            // int priceInt = (int) price;
            // Console.WriteLine(price);       // 14.99
            // Console.WriteLine(priceInt);    // 14
            
            // can also use Convert class
            // string priceString = Convert.ToString(price);
            // Console.WriteLine("priceString is " + priceString);
            
            // Getting user input using Console.ReadLine()
            // Console.Write("First name: ");
            // string firstName = Console.ReadLine();
            // Console.Write("Last Name: ");
            // string lastName = Console.ReadLine();
            // string welcomeMessage = $"Good morning {firstName} {lastName}";
            // Console.WriteLine(welcomeMessage);
            
            // accessing characters in a string
            // Console.WriteLine("Your initials are: {0}{1}",  Convert.ToString(firstName[0]).ToUpper(), Convert.ToString(lastName[0]).ToUpper());

            // messing around with conditional statements
            // Console.Write("Enter a number: ");
            // int x = Convert.ToInt32(Console.ReadLine());
            // if (x < 10)
            // {
            //     Console.WriteLine("{0} is less than 10", x);
            // }
            // else if (x == 10)
            // {
            //     Console.WriteLine("{0} is equal to 10", x);
            // }
            // else
            // {
            //     Console.WriteLine("{0} is greater than 10", x);
            // }
            
            // shorthand (ternary operator)
            // string message = (x < 10) ? $"{x} < 10" : $"{x} >= 10";
            // Console.WriteLine(message);
            
            // practising with loops
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine(i);
            // }
            //
            // for each loop for arrays
            // string[] places = {"London", "Paris", "New York", "Tokyo"};
            // foreach (string place in places)
            // {
            //     Console.WriteLine(place);
            // }
            
            // creating an array
            // string[] cars = { "Citroen", "Volkswagen", "Ford" };
            // Console.WriteLine("the first entry of cars array is {0}", cars[0]);
            
            // changing an array element
            // cars[0] = "Renault";
            // Console.WriteLine("the first entry of cars array is now {0}", cars[0]);
            
            // checking the length of an array
            // Console.WriteLine("the cars array has {0} elements", cars.Length);
            
            // declare a new array without filling it in
            // string[] names;
            // names = new string[] {"Alice", "Bob", "Charlie" };
            // Console.WriteLine("the third element of names array is {0}", names[2]);
            
            // we can use the Sort method to order things alphabetically or numerically
            // Array.Sort(cars);
            // Console.WriteLine("cars in alphabetical order:");
            // foreach (string car in cars)
            // {
            //     Console.WriteLine(car);
            // }
            //
            // int[] prices;
            // prices = new int[] { 73, 15, 673, 72, 19 };
            // Array.Sort(prices);
            // Console.WriteLine("prices from smallest to largest:");
            // foreach (int p in prices)
            // {
            //     Console.WriteLine(p);
            // }
            
            // multi dimensional arrays
            // string[,] grid =
            // {
            //     { "00", "01", "02" },
            //     { "10", "11", "12" },
            //     { "20", "21", "22" }
            // };
            
            // looping through the array
            // for (int i = 0; i < grid.GetLength(0); i++)
            // {
            //     for (int j = 0; j < grid.GetLength(1); j++)
            //     {
            //         Console.Write(grid[i, j] + " ");
            //     }
            //     Console.WriteLine("");
            // }
            
            // try catch
            // try
            // {
            //     Console.Write("Give me an integer: ");
            //     int num = Convert.ToInt32(Console.ReadLine());
            //
            //     Console.WriteLine(Product(num, 10));
            // }
            // catch
            // {
            //     Console.WriteLine("ERROR: Please provide a valid integer");
            // }

            // double[] nums = { 67, -52, 0, 89, 15, 73, 24 };
            

            // testing return array function
            Console.WriteLine(
                "Please provide a list of numbers each separated by a comma. Please do not include any special characters");
            string numberString = Console.ReadLine();
            try
            {
                double[] numberArray = ConvertStringToArray(numberString);
                Console.WriteLine("The numbers you provided are: ");
                foreach (double num in numberArray)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine("----- Info -----");
                Console.WriteLine("Mean: {0:F2}", Mean(numberArray));
                Console.WriteLine("Median: {0:}", Median(numberArray));
                Console.WriteLine("Min: {0}", Min(numberArray));
                Console.WriteLine("Max: {0}", Max(numberArray));
                Console.WriteLine("Stdev: {0:F2}", Stdev(numberArray));
            }
            catch
            {
                Console.WriteLine("ERROR: Could not make an array of numbers from the string given. Make sure you separate each number with a single comma and do not include special characters");
            }
            
        }
    }
}












