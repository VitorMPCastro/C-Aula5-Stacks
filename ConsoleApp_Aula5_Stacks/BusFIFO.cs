using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Aula5_Stacks
{
    internal class BusFIFO
    {
        private static Queue<string> terminal = new();

        public static void PrintQueue() {
            Console.WriteLine(terminal.ToString());
        }

        public static void AddToQueue(int busNumber, string destination)
        {
            terminal.Enqueue(busNumber + " - " + destination);
        }

        public static void RemoveFromQueue()
        {
            Console.WriteLine(terminal.Dequeue() + " Departed.\n");
        }

        public static void PrintNext()
        {
            Console.WriteLine(terminal.Peek() + " is next.\n");
        }

        public static void PrintAll()
        {
            foreach (string bus in terminal)
            {
                Console.WriteLine(bus);
            }
        }

        public static void Count()
        {
            Console.WriteLine("There are " + terminal.Count + " buses in the terminal.\n");
        }

    }
}
