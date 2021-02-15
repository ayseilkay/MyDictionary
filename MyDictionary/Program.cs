using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Hg", "Civa");
            myDictionary.Add("Au", "Altın");
            myDictionary.Add("Al", "Alüminyum");

            myDictionary.Key("Hg");
            myDictionary.Key("Au");
            myDictionary.Key("Al");
            myDictionary.Key("Ni");// bu key mevcut değil
            Console.ReadLine();
        }
    }
}
