using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Will 1", "Will 2", "Ethan", "Ashton", "Ben", "Tom", "Henry", "Cormac", "Adam" };
            List<int> scores = new List<int> { 9, 2, 3, 10, 5, 6, 7, 4, 8, };


            for (int n = 0; n < 9; n++)
            {
                Console.WriteLine(names[n] + " = " + scores[n]);
            }
            Console.ReadLine();
        }
    }
}
