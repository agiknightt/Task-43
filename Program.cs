using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_43
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stew> stews = new List<Stew>();
            int thisYear = 2020;

            AddStews(stews);

            var filteredStews = from Stew stew in stews where stew.ProductionYear + stew.ExpirationDate < thisYear select stew;

            Console.WriteLine("Просроченые банки тушенки : ");

            foreach (var stew in filteredStews)
            {
                stew.ShowInfo();
            }
            
            Console.ReadKey();
        }

        private static void AddStews(List<Stew> stews)
        {
            stews.Add(new Stew("Тушенка", 2000, 5));
            stews.Add(new Stew("Тушенка", 2010, 15));
            stews.Add(new Stew("Тушенка", 2015, 7));
            stews.Add(new Stew("Тушенка", 2005, 8));
            stews.Add(new Stew("Тушенка", 2009, 8));
        }
    }
    class Stew
    {
        public string Name { get; private set; }
        public int ProductionYear { get; private set; }
        public int ExpirationDate { get; private set; }
        public Stew(string name, int productionYear, int expirationDate)
        {
            Name = name;
            ProductionYear = productionYear;
            ExpirationDate = expirationDate;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Название - {Name}, год производства - {ProductionYear}, срок годности {ExpirationDate} лет.");
        }
    }
}
