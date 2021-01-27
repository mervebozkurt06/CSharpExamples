using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> CountryAndCity = new MyDictionary<string,string>();
            CountryAndCity.Add("Massachusetts", "Boston");
            CountryAndCity.Add("Ohio", "Cincinnati");
            CountryAndCity.Add("Texas", "Houston");

            Console.WriteLine("All records..");
            Console.WriteLine("****************");
            CountryAndCity.PrintAll();
            Console.WriteLine("****************");
            Console.WriteLine("number of records="+CountryAndCity.Count);

            
        }
    }
}
