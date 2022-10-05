using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOfFive
{
    public class CSharpChallenge
    {
        public static void Main(string[] args)
        {
            string multiples = "";
            foreach (int i in Enumerable.Range(1, 99))
            {
                multiples += (i * 5);
                multiples += " ";
            }
            multiples = multiples.Remove(multiples.Length - 1, 1);
            Console.Write(multiples);
        }
    }
}
