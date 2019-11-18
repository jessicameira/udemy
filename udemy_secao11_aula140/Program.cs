using System;
using System.IO;

namespace udemy_secao11_aula140
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch(Exception e) {
                Console.WriteLine("Error! " + e.Message);
            }
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e) {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

        }
    }
}
