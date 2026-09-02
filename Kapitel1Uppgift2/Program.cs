using System;
namespace Kapitel1Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Ett problem har uppstått på datorn. Den måste startas om.");
            Console.Write("Först kommer felinformation att samlas in och sedan utförs omstart automatiskt.");
        }
    }
}