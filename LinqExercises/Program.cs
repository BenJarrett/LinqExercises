using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>() {8, 3, 11, 23, 9, 2, 7, 300 };

            // SORTING OPERATION // - ORDERS THE ELEMENTS IN SOME TYPE OF SEQUENCE BASE ON ATTRIBUTES //

            //// ORDER BY // - DOES NOT CHANGE ORIGINAL COLLECTION BECAUSE IT RETURNS SOMETHING NEW // 
            //var orderedNumbers = numbers.OrderBy(num => num);

            //Console.WriteLine("Order By:");

            //foreach (int num in orderedNumbers)
            //{
            //    Console.WriteLine(num);
            //}


            //// ORBER BY DESCENDING // - DOES NOT CHANGE ORIGINAL COLLECTION BECAUSE IT RETURNS SOMETHING NEW // 
            //// Can also do a ForEach loop, this is just another way to do it //
            //var orderedByDescending = numbers.OrderByDescending(num => num);
            //Console.WriteLine($"Descending: { String.Join( ',', orderedByDescending)}");


            //// REVERSE // - Return type is void, so we can't make a variable to store the return like the first two //
            //// CHANGES THE ORIGINAL COLLECTION BECAUSE THE RETURN TYPE IS VOID // - MUTATES ORIGINAL COLLECTION //
            //numbers.Reverse();

            //Console.WriteLine("Reverse:");

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            // END OF SORTING DATA //

            // AGGREGATE METHODS // - GETS SINGLE VALUE FROM A COLLECTION OF VALUES //
            // USED FOR: AVERAGE //
            // USED FOR: MAX //
            // USED FOR: SUM //
            // USED FOR: MIN //
            // USED FOR: COUNT //
            // USED FOR: AGGREGATE //

            //List<int> numbers2 = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };

            // MAX //
            //var maxNumber = numbers2.Max();
            //Console.WriteLine("Max:");
            //Console.WriteLine(maxNumber);

            //// MIN // 
            //var minOfNumbers = numbers2.Min();
            //Console.WriteLine("Min:");
            //Console.WriteLine(minOfNumbers);


            //// SUM // 
            //var sumOfNumbers = numbers2.Sum();
            //Console.WriteLine("Sum:");
            //Console.WriteLine(sumOfNumbers);

            //// AVERAGE //
            //var averageNumber = numbers2.Average();
            //Console.WriteLine("Average:");
            //Console.WriteLine(averageNumber);

            //// COUNT // - Returns the number of elements in that collection - SIMILAR TO .LENGTH //
            //var countOfNumnbers = numbers2.Count();
            //Console.WriteLine("Count:");
            //Console.WriteLine(countOfNumnbers);

            //// END OF AGGREGATE METHODS //

            //// FILTER METHODS // - FILTERS BASED ON CONDITION // - RETURNS A NEW COLLECTION //
            //// WHERE // - RETURNS SOMETHING // - SIMILAR TO ARRAY.FILTER() IN JAVASCRIPT //

            //// EXAMPLE -- WE WANT ALL THE NUMBERS GREATER THAN 9 //

            //var biggerNumbers = numbers2.Where( taco => taco > 9 );
            //Console.WriteLine($"While: { String.Join(',', biggerNumbers)}"); 

            // END OF FILTER METHODS //


            // PROJECTION METHODS //
            // TRANSFORMING DATA //

            // SELECT // - SIMILAR TO ARRAY.MAP - RETURNS A NEW COLLECTION  OF IEnunerable<T> //
            // IN THIS EXAMPLE, WE ARE ADDING 12 TO EACH VALUE IN THE COLLECTION //

            //var biggerNumbers2 = numbers2.Select(num => num + 12);
            //Console.WriteLine("Select:");
            //Console.WriteLine($"Select: { String.Join(',', biggerNumbers2)}");

            // END OF PROJECTION METHODS //


            // ELEMENT METHODS/OPERATIONS // - USED IN SQL // 
            // RETURN A SINGLE OR SPECIFIC ELEMENT FROM A SEQUENCE //
            // CAN BE MIXED WITH 'WHERE' FUNCTION - To find the mathcing item of something //

            List<int> numbers3 = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };

            // FIRST (OR DEFAULT) // - DEFAULT IF NOTHING MATCHES WHAT WE ASKING IT TO MATCH //
            var firstNumber = numbers3.First();
            Console.WriteLine("First:");
            Console.WriteLine(firstNumber);

            // LAST //
            var lastNumber = numbers3.Last();
            Console.WriteLine("Last:");
            Console.WriteLine(lastNumber);

            // METHOD CHAINING or LINQING //
            // FIRST COMBINDED WITH WHILE //
            // First mathcing item //
            // EXAMPLE - Finds first number that is greater than 9 //

            var firstMatchingNumber = numbers3.Where(num => num > 9).First();

            // CAN ALSO DO //
            var firstMatchingNumber2 = numbers3.First(num => num > 9);

            Console.WriteLine("First + While:");
            Console.WriteLine(firstMatchingNumber);
            Console.WriteLine(firstMatchingNumber2);

            // END OF ELEMENT METHODS //

        }
    }
}
