using System;

namespace SD_Class_OverflowException
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.MaxValue;
            try
            {
                string result = number1 + "1";
                int.Parse(result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
