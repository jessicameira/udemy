using System;
using System.Collections.Generic;

namespace udemy_secao6_aula76
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            List<string> lista2 = new List<string> { "Alex", "Maria", "Joao" };

            Console.WriteLine(lista2);

            lista.Add("Jose");
            lista.Add("Joao");
            lista.Add("Maria");
            lista.Add("Ana");
            lista.Add("Alex");
            lista.Insert(2, "Marco");

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("conta: " + lista.Count);

            /* string s1 = lista.Find(teste);*/

            string s1 = lista.Find(x => x[0] == 'A');
            string s2 = lista.FindLast(x => x[0] == 'A');

            Console.WriteLine("First A: " + s1);
            Console.WriteLine("Last A: " + s2);

            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("posicao: " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posicao: " + pos2);

            List<string> lista3 = lista.FindAll(x => x.Length == 5);

            foreach(string nome in lista3)
            {
                Console.WriteLine(nome);
            }

            lista.Remove("Alex");
            foreach(string l1 in lista)
            {
                Console.WriteLine("-----------------" + l1);
            }
            lista.RemoveAll(x => x[0] == 'M');

            foreach(string l2 in lista)
            {
                Console.WriteLine("***" + l2);
            }

            lista.RemoveAt(1);
            foreach (string l3 in lista)
            {
                Console.WriteLine("+++++++" + l3);
            }

            lista.RemoveRange(0, 1);
            foreach(string l4 in lista)
            {
                Console.WriteLine(l4);
            }


        }

        /* static bool teste (string s)
         {
             return s[0] == 'A';
         }*/
    }
}
