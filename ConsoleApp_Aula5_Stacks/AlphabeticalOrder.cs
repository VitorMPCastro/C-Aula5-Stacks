using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Aula5_Stacks
{
    internal class AlphabeticalOrder
    {
        private List<String> cars = [];

        public AlphabeticalOrder()
        {
            cars = ["Mercedes-Benz", "Jaguar", "Rolls-Royce", "BMW", "Aston Martin", "Lamborghini", "Ferrari"];
        }

        public AlphabeticalOrder(List<String> cars)
        {
            this.cars = cars;
        }

        public void Sort()
        {
            this.cars.Sort();
        }

        public void print()
        {
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("\n");
        }
    }
}
