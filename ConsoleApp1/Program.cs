using System;

namespace ConsoleApp1
{
    class Program
    {
        //Hello Github I'm nifanfa
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToByte("00011001", 2));
            Console.ReadKey();

            /*
            string s = string.Empty;

            for (byte i = 0x00; i < 0x7F; i++)
            {
                string c = Encoding.ASCII.GetString(new byte[] { i });
                s += c;
            }

            File.WriteAllText("ASCII.txt", s);
            */
        }
    }
}
