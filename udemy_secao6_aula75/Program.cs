using System;

namespace udemy_secao6_aula75
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
