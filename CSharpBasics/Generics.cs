using System;
using System.Collections.Generic;

namespace LearningClasses
{
    public class Generic
    {
        void LearningList()
        {
            List<string> names = new List<string>();
            names.Add("Sagar Shree");
            names.Add("Sagar Shree");
            names.Add("Sagar Shree");
            names.Add("Sagar Shree");
            names.Add("Sagar Shree");
            names.Add("Sagar Shree");

        }
        void LearningDictionary()
        {
            Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
            countryCapitals.Add("Nepal", "Kathmandu");
            countryCapitals.Add("USA", "Washington DC");
            foreach (var countryCaptital in countryCapitals)
            {
                Console.WriteLine(countryCaptital.Key);
            }

        }
    }
}