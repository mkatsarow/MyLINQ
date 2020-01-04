using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQbyMihailKatsarov
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test case for Filter/Where

            var movies = new List<Movie>
             {
                 new Movie { Title = "The Dark Knight", Rating = 8.9F, Year = 2009},
                 new Movie{Title = "The kings Speach", Rating = 8.0F, Year = 2001 },
                 new Movie{ Title = "Casablanca", Rating = 8.5F, Year = 1999 },
                 new Movie{Title = "Star wars V", Rating = 8.7F, Year = 1988 }
             };

            
            var query = movies.Where(m => m.Year > 2000);

            movies.Add(new Movie { Title = "Hello", Rating = 9.5F, Year = 2005 });


            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Title);
            //}
    
            var enumerator = query.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(1);
            }

            //===========================================================================//

            //Testh method for min value of IEnumerable collection

            //int[] numbers = { 1,2,3,4,5 };

            //var result = numbers.MyMin();

            //Console.WriteLine(result);

            //===========================================================================//

            //Test method for min value of IEnumerable nullable int collection

            //int[] nullableNUmbers = null;
            //int?[] nullableNUmbers2 = { };
            //int?[] nullableNUmbers3 = { 1, 2, 3 };

            //var resultNullabe = nullableNUmbers3.MyMinNullable();

            //Console.WriteLine(resultNullabe);

            //===========================================================================//

            //Test method for max value of IEnumerable  int collection

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //var result = numbers.MyMax();

            //Console.WriteLine(result);

            //===========================================================================//

            //Test method for Count of IEnumerable collection

            //int[] numbers = { 1, 1, 1 };

            //var result = numbers.MyCount();

            //Console.WriteLine(result);

            //===========================================================================//

            //Test method for AVG of IEnumerable<int> collection

            //int[] numbers = { 1, 2, 3, 4, 5 ,1};

            //var result = numbers.MyAvg();

            //Console.WriteLine(result);

            //===========================================================================//

            //Test method for Aggregate

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var result = numbers.Select((num, index) => new { Number = num, Index = index });
            //                    //.Where(x=> x.Number % 2 == 0);


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Number+ " - " + item.Index);
            //}


        }
    }
}
