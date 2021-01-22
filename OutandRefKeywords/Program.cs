using System;

namespace OutandRefKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 3;
            int number2 = 4;
            var result = Add(ref number1, number2);

            Console.WriteLine(result); //9
            Console.WriteLine(number1); //5
        }

         static int Add(ref int number1, int number2)
        {
            number1 = 5; //number1s value changed because of ref tag
            return number1 + number2;
        }
    }
}
