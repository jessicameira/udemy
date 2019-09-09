using System;

namespace udemy_secao7_aula89
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            string original = "  abcd e FGH IjKlm abxcabcxabcx ";
            string s1 = original.ToUpper();

            Console.WriteLine(original);
            Console.WriteLine(s1);
            string s2 = original.ToLower();
            Console.WriteLine(s2);
            string s3 = original.Trim();
            Console.WriteLine(s3);
            int n1 = original.IndexOf("bc");
            Console.WriteLine(n1);
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            Console.WriteLine(s4);
            string s5 = original.Substring(3, 5);
            Console.WriteLine(s5);

            string s6 = original.Replace("a", "x");
            Console.WriteLine(s6);

            bool b1 = string.IsNullOrEmpty(original);
            Console.WriteLine(b1);
            bool b2 = string.IsNullOrWhiteSpace(original);
            Console.WriteLine(b2);
        }
    }
}
