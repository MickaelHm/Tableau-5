using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 3, 4, 5, 6};
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Add(7);
            numbers.Insert(0, 1);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            

        }
    }
}
