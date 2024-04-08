using ConsoleApp_Aula5_Stacks;

namespace ConsoleApp_Aula5_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            DecimalToBinary.Convert(13);
            Console.WriteLine("\n");

            AlphabeticalOrder alphabeticalOrder = new();
            alphabeticalOrder.Sort();
            alphabeticalOrder.print();
            alphabeticalOrder = new(["Mercedes-Benz", "Jaguar", "Rolls-Royce", "BMW", "Aston Martin", "Lamborghini", "Ferrari", "Mazda", "Lotus", "Max Verstappen"]);
            alphabeticalOrder.Sort();
            alphabeticalOrder.print();

            Matrix matrix = new();
            matrix.print();
            matrix.Transpose();
            matrix.print();
            matrix = new(4, 5);
            matrix.print();
            matrix.Transpose();
            matrix.print();

            BusFIFO.AddToQueue(1, "São Paulo");
            BusFIFO.AddToQueue(2, "Rio de Janeiro");
            BusFIFO.AddToQueue(3, "Curitiba");
            BusFIFO.AddToQueue(4, "Belo Horizonte");
            BusFIFO.AddToQueue(5, "Brasília");
            BusFIFO.AddToQueue(6, "Porto Alegre");
            BusFIFO.AddToQueue(7, "Salvador");
            BusFIFO.Count();
            BusFIFO.PrintAll();
            BusFIFO.PrintNext();
            BusFIFO.RemoveFromQueue();
            BusFIFO.Count();
            BusFIFO.PrintAll();

        }
    }
}