using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
       

        K[] country;
        V[] city;
        K[] tempCountry;
        V[] tempCity;
        //constructor
        public MyDictionary()
        {
            

            country = new K[0];
            city = new V[0];
        }

        public void Add( K key, V value)
        {
            

            tempCity = city;
            tempCountry = country;
            country = new K[tempCountry.Length + 1];
            city = new V[tempCity.Length + 1];
            for (int i = 0; i < tempCountry.Length; i++)
            {
                country[i] = tempCountry[i];
                city[i] = tempCity[i];
             }
            country[country.Length - 1] = key;
            city[city.Length - 1] = value;


        }

        public int Length
        {
            get { return country.Length; }
        }
        public int Count
        {
            get { return country.Length; }
        }

        public void PrintAll()
        {
            for (int i = 0; i < country.Length; i++)
            {
                Console.WriteLine("Country : "+country[i] );
                Console.WriteLine("City : "+city[i]     );

            }
        }
    }
}
