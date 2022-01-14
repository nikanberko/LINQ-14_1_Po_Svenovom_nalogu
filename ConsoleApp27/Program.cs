using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Package> packages = new List<Package>();
            packages.Add(new Package(100, "Osijek", 1));
            packages.Add(new Package(100, "Slunj", 1));
            packages.Add(new Package(120, "Pula", 1));
            packages.Add(new Package(75, "Zagreb", 2));
            packages.Add(new Package(150, "Zagreb", 3));

            double avgWeightZagreb = packages.Where(p => p.City == "Zagreb").Select(p => p).Average(p => p.Weight);
            Console.WriteLine(avgWeightZagreb);

            int priorityOfHeaviestPackage = packages.Where(p => p.Weight == packages.Max(p => p.Weight)).Select(p => p.Priority).ElementAt(0);
            Console.WriteLine(priorityOfHeaviestPackage);

            List<string> citiesOfLowestPriorityPackagesAlphabeticallySorted = packages.Where(p => p.Priority == packages.Min(p => p.Priority)).Select(p => p.City).OrderBy(p=>p).ToList();

            foreach(string city in citiesOfLowestPriorityPackagesAlphabeticallySorted)
            {
                Console.WriteLine(city);
            }

            ////DRUGA OPCIJA ZA ZADNJI ZADATAK-Nakon sto pretvorite sve u listu mozete koristiti .ForEach(p=> Console.WriteLine(p)) i svaki p u odabiru ispisati
            packages.Where(p => p.Priority == packages.Min(p => p.Priority)).Select(p => p.City).OrderBy(p => p).ToList().ForEach(p => Console.WriteLine(p));
        }
    }
}
