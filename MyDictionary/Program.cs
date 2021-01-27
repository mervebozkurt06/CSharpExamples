using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDic<string> cities = new MyDic<string>();
            cities.Add("Boston");

            Console.WriteLine(cities.Length);

            cities.Add("New York");

            Console.WriteLine(cities.Length);

            
        }
    }
}
