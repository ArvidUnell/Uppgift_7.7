using System;
using System.Collections.Generic;
namespace Uppgift_7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strängar1 = { "a", "b", "b", "c", "hej" };
            string[] strängar2 = { "hej", "a", "a", "b", "programmering" };

            foreach (string utSträng in FinnsIBåda(strängar1,strängar2))
            {
                Console.WriteLine(utSträng);
            }
        }
        static string[] FinnsIBåda(string[] arr1, string[] arr2)
        {
            List<string> lista = new List<string>();

            foreach (string sträng in arr1)
            {
                if (arr2.Contains(sträng) && !lista.Contains(sträng))
                {
                    lista.Add(sträng);
                }
            }
            return lista.ToArray();
        }
    }
}