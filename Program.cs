using System;

namespace Convertendo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "2021-12-12";
            DateTime Alterado = DateTime.ParseExact(data, "yyyy-MM-dd", null);
            Console.WriteLine("\nResultado: " + Alterado);
        }
    }
}
