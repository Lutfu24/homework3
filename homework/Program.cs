using Microsoft.VisualBasic;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Num();
        }
        static void Num()
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            if (number%7==0)
            {
                Console.WriteLine("7-ye bolunur");
            }
            else if (number%7>=4)
            {
                Console.WriteLine(number+7-number%7);
            }
            else
            {
                Console.WriteLine(number-number%7);
            }
        }
    }
}