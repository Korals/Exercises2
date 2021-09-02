using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feel free to test out your stuff below...");
            var numbers = new[] {1,-3,5,-10,-5 };
            var result = PositiveNegativeNumbers(numbers);

            Console.WriteLine(result);
        }

        // Generate a list of numbers from given number to given number
        // Input: 2, 5
        // Output: a list of integers => 2, 3, 4, 5
        // Input: 9, 15
        // Output: a list of integers => 9, 10, 11, 12, 13, 14, 15
        public static List<int> GetNumbersFromTo(int from, int to)
        {
            var size = to - from + 1;
            var result = Enumerable.Range(from, size).ToList();
            //foreach (var n in result)
            //    Console.WriteLine(n);

            return result;
        }

        // Reverse a given string
        // Input: Vilius
        // Output: suiliV
        public static string ReverseString(string someString)
        {
            char[] temp = someString.ToCharArray();
            Array.Reverse(temp);
            

            return new string (temp);
        }

        // Get name initials form full name
        // Input: Vilius Zobela
        // Output: V.Z.
        public static string GetNameInitials(string fullName)
        {
            string[] names = fullName.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            foreach (string ch in names)
                result += ch.Substring(0, 1).ToUpper() + ".";

            return result;
        }

        // Get birth date form personal code
        // Input: 39712043371
        // Output: DateTime object set to date 1997-12-04
        public static DateTime? ExtractBirthdateFromPersonalCode(string personalCode)
        {
            /*
            char[] temp = personalCode.ToCharArray();

            var yyyy = "19" + temp[1] + temp[2];
            var mm ="-"+ temp[3] + temp[4];
            var dd = "-"+temp[5] + temp[6];
            Console.WriteLine(yyyy + mm + dd);

            var year = Convert.ToInt32(yyyy);
            var month = Convert.ToInt32(mm);
            var day = Convert.ToInt32(dd);

            //string result = yy + temp[1] + temp[2] + "-" + temp[3] + temp[4] + "-" + temp[5] + temp[6];
            var result = new DateTime(year, month, day);

            return result;
            */
            return null;
        }

        // You're given a grades array (int) find student's average grade
        // Input: { 10, 9, 4, 3 }
        // Output: 6.5
        public static double GetAverageGrade(int[] grades)
        {
            
            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
                sum += grades[i];

            Console.WriteLine("Sum: " + sum);

            double result = sum / grades.Length;

            return result;
        }

        // You're given the original item price and a discount percentage, calculate the item's price after the discount is applied
        // Input: 330, 10
        // Output: 297
        public static int CalculateDiscount(int originalPrice, int discount)
        {
            //int result = originalPrice * ((100 - discount) / 100);

            var result = (originalPrice * (100 - discount)) / 100;

            return result;
        }

        // Create a program that takes the input int array and returns a string array which corresponds to each number and says whether the number is
        // positive or negative
        // Input: { 1, -3, 5, -10, -5 }
        // Output: { "positive", "negative", "positive", "negative", "negative" }
        public static string[] PositiveNegativeNumbers(int[] numbers)
        {
            var size = numbers.Length;
            string[] result;
            result = new string[size];

            for (int n = 0; n < size; n++)
            {
                if (numbers[n] > 0)
                    result.SetValue("positive", n);
                else if (numbers[n] == 0)
                    result.SetValue("N/A", n);
                else if (numbers[n] < 0)
                    result.SetValue("negative", n);
            }

            return result;
        }
    }
}