using System;

namespace Functions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Greetings();
            GreetAUser("Jack");
            SumTwoNumbers(15,16);
            CountNumberOfSpaces("This is Saturday a test string.");
            

            int [] numberArray = {5,3,7,2,9};

            SumOfElementsInArray(numberArray);
            SwapValues(4,5);
            RaiseIntegerToPowerOf(5,11);
            Fibonacci(10);
            IsPrimeNumber(31);
            AddNumbers(123456789);
            Factorial(5);
            GetSpecificFibonacciTerm(10);

            
        }

        private static void Greetings()
        {
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice day!");


        }

        private static void GreetAUser(string name)
        {
            Console.WriteLine("Welcome Friend " + name +  "!");
            Console.WriteLine("Have a nice day!");
        }
        private static void SumTwoNumbers(int firstNumber,int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine("The sum of two numbers is : " + result);
        }
        private static void CountNumberOfSpaces(string text)
        {
            int spaceCounter = 0;
            int counter = 0;

            while (counter < text.Length) {
                if (text[counter] == ' ')
                {
                    spaceCounter = spaceCounter + 1;
                }
                counter= counter + 1;
            }

            Console.WriteLine( text + ". Contains " + spaceCounter + " spaces" );

        }

        private static void SumOfElementsInArray(int [] array)
        {
            int totalSum = 0;
            int counter = 0;

            while ( counter < array.Length) {

                totalSum = totalSum + array[counter];

                counter = counter + 1;
            }
            Console.WriteLine( "The sum of the elements of the array is " + totalSum);

        }

        private static void SwapValues(int firstNumber,int secondNumber)
        {
            int tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;
            Console.WriteLine( "Now the 1st number is "+ firstNumber +", and the 2nd number is "+ secondNumber);

        }
        
        private static void RaiseIntegerToPowerOf(int baseNumber,int exponent)
        {
            double result = Math.Pow(baseNumber, exponent);
            Console.WriteLine (result);
        }

        private static void Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)

            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine("");
        }
        private static void IsPrimeNumber(int number)
        {

            if (number == 0 || number == 1)
            {
                Console.WriteLine(number + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= number / 2; a++)
                {
                    if (number % a == 0)
                    {
                        Console.WriteLine(number + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(number + " is a prime number");

            }
            
        }
        private static void AddNumbers(int number)
        {
            int totalSum = 0;
            string numberAsString = number.ToString();
            for (int i = 0; i < numberAsString.Length ; i++)
            {
                int currentNumber = Convert.ToInt32(numberAsString[i].ToString());
                totalSum = totalSum + currentNumber;         
            }

            Console.WriteLine("The sum of the digits of the number " + number + " is " + totalSum);
        }
        private static double CalculateFactorial(int number)    
        {    
            if (number == 0)    
                return 1;    
            return number * CalculateFactorial(number-1);//Recursive call    
    
        }     
        private static void Factorial(int number)
        {
            double result = CalculateFactorial(number);
            Console.Write("The factorial of the digits of the number " + number + "! is " + result);
            Console.WriteLine("");
            
        }

        private static int FibonacciRecursive(int number)
        {
            if (number == 0)
            {
                
                //Console.WriteLine(0);
                return 0;
                
            }
            else if (number == 1)
            {
                //Console.WriteLine(1);
                return 1;
            }
            else
            {
                int result = (FibonacciRecursive(number-1)+FibonacciRecursive(number-2));
                //Console.WriteLine(result);
                return(result);
            }

        }

        private static void GetSpecificFibonacciTerm(int number)
        {
            int result = FibonacciRecursive(number);
            Console.Write("The Fibonacci of the " + number + "th term is " + result);
            
        }
        
    }
}
