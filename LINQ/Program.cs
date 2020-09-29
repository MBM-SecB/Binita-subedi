using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ - Language Integrated Query
            int[] numbers = {12, 13, 14, 15, 16, 17, 18, 89, 25, 54, 87, 33, 66, 77, 85};
            var result1 = numbers.Where(num => num > 50).Select(num => num);
            
            // Query expression syntax
            var result2 = from num in numbers
                           where num > 50
                           select num;

            // Restriction - where
            var result3 = from num in numbers
                           where num > 50 && num < 70
                           select num;
            // Projection - select 
            var result4 = from num in numbers
                         where num % 2 == 0
                         select num * num;

            // Ordering
            var result5 = from num in numbers
                        orderby num descending
                        select num;
            // Partitioning: take
            var result6 = numbers.Skip(5).Take(5); 
            //
            var result7 = numbers.Any(num => num % 2 == 0);
            var result8 = numbers.All(num => num % 2 ==0);               
            var result9 = numbers.Contains(23); 
        }
        void LearnLinqOnComplexCollection()
        {
            Country c1 = new Country("Nepal","Kathmandu", "Asian", 324567)
            Country c2 = new Country("India","Delhi", "Asian", 123567, DateTime.Parse)
            Country c3 = new Country("England","GB", "Europe", 456783)
            Country c4 = new Country("Bhutan","Thimpu", "Asian", 123467)
            Country c5 = new Country("Russia","Mosco", "Europe", 678905)
            Country c6 = new Country("Australia","Canberra", "Australia", 453215, DateTime.Parse("1943/11/1"))

            var countries = new List<Country> { c1, c2, c3, c4, c5, c6 };

            //List all asian cuntry names
            var result1 = from country in countries
            where country.Continent == "Asia"
            select country.Name;
        }
    }
}
