
using System;

public class Calculator 
{


    public int Add(int first, int second) { 
    
         return first + second; 
    }

    //public void Dispose()
    //{
    //    //todo
    //}

    public int subtraction(int first, int second) {

        if (first < second) {

            throw new ArgumentException($"First number {first} is less than the second number {second}");
        }
         return first - second;
    }


    public int[] GetNumbers()
    {
        return new int[] { 1, 2, 3, 4, 5 };
    }

    public class Program
    {
        public static void Main()
        {
            //Calculator calculator = new Calculator();
            //int result = calculator.Add(5, 7);
            //Console.WriteLine($"The result of adding 5 and 7 is {result}");

            //int result2 = calculator.Subtraction(10, 3);
            //Console.WriteLine($"The result of subtracting 3 from 10 is {result2}");
        }
    }




}