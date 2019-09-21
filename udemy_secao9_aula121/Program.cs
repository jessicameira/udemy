using System;
using udemy_secao9_aula121.Entities;

namespace udemy_secao9_aula121
{
    class Program
    {
        static void Main(string[] args)
        {
            Comments c1 = new Comments("Have a nice Trip!");
            Comments c2 = new Comments("Wow thats awesome!");
            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);

            p1.AddComent(c1);
            p1.AddComent(c2);

            Console.WriteLine(p1);
        }
    }
}
