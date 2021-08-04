using System.Collections.Generic;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>() {8, 3, 11, 23, 9, 2, 7, 300 };

            //// SORTING DATA // 

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
            List<int> numbers2 = new List<int>() { 8, 3, 11, 23, 9, 2, 7, 300 };

        }
    }
}
