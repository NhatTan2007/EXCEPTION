using System;

namespace SD_Class_FormatException
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 169.32m;
            try
            {
                Console.WriteLine("The cost is {0:Q2}.", price);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
