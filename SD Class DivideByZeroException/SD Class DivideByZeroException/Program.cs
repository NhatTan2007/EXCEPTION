using System;

namespace SD_Class_DivideByZeroException
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 30000;
            int b = 0;
            
            try
            {
                int result = a / b;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
