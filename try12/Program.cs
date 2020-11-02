using System;
using System.Collections.Generic;

namespace try12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IStor> stors = new List<IStor>();
            stors.Add(new Car { name = "aa", Price = 2000, weight = 5000 });
            stors.Add(new Car { name = "bb", Price = 5000, weight = 7000 });
            stors.Add(new Bike { name = "aa", Price = 4000, weight = 9000 });
            stors.Add(new Bike { name = "aa", Price = 1000, weight = 3000 });
            Ivisitor visitorPrice = new Pricevisitor();
            Ivisitor visitorWeight = new Weightvisitor();
            foreach (var item in stors)
            {
                item.Visit(visitorPrice);
                item.Visit(visitorWeight);
            }
            Console.ReadKey();
        }
    }
    public class Pricevisitor : Ivisitor
    {
        public void Accept(Car car)
        {
            Console.WriteLine("car price is"+car.Price);
        }

        public void Accept(Bike bike)
        {
            Console.WriteLine("bike price is" + bike.Price);
        }
    }
    public class Weightvisitor : Ivisitor
    {
        public void Accept(Car car)
        {
            Console.WriteLine("car Weight is" + car.weight);
        }

        public void Accept(Bike bike)
        {
            Console.WriteLine("bike Weight is" + bike.weight);
        }
    }
}
