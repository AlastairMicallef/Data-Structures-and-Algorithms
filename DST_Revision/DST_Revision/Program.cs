using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST_Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s1 = { 1, 2, 3, 4, 3, };
            SetDS set1 = new SetDS(s1);

            int[] s2 = { 5, 6, 7, 8 };
            SetDS set2 = new SetDS(s2);

            int countOf3 = set1.Count(3);
            Console.WriteLine("How many 3s in set 1?" + countOf3);

            SetDS unionSet = (SetDS)set1.Union(set2);
            foreach(int num in unionSet.SetOfNumbers){
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
