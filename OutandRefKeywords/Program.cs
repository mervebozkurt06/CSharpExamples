using System;

namespace OutandRefKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 3;
            int number2 = 4;
            var resultOfRef = Add1(ref number1, number2);

            int number3 ;
            int number4 = 10;
            var resultOfOut = Add2(out number3, number4);

            Console.WriteLine(resultOfRef); //9
            Console.WriteLine(number1); //5

            Console.WriteLine(resultOfOut); //11
            Console.WriteLine(number1); //1
        }

         static int Add1(ref int number1, int number2)
        {
            number1 = 5; //number1s value changed because of "ref" tag
            return number1 + number2;
        }

        static int Add2(out int number3, int number4)
        {
            number3 = 1; //number3 changed because of "out" tag
            return number3 + number4;
        }
    }
}
