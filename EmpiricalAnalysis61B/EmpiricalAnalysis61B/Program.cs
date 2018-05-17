using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricalAnalysis61B
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrayBasedVector = new List<int>();

            Stopwatch sw = new Stopwatch();


            int repetitions = 100000;

            int[] problemSizes = new int[] { 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000 };

            foreach (int size in problemSizes)// foreach different problem size
            {
                sw.Reset(); // set the stopwatch to 0

                arrayBasedVector.Clear(); // set the size of the arrayBasedVector back to 0
                for (int i = 0; i < size; i++)
                {
                    arrayBasedVector.Add(i); // add an element
                }

                //The arrayBasedVecor now has number of elements equal to size 

                arrayBasedVector.Add(-1); //Insert the value 1000 at rank 0
                arrayBasedVector.RemoveAt(arrayBasedVector.Count - 1); //since we have added 1 element,
                                                                       //we need to remove 1 element
                                                                     


            }

            arrayBasedVector.Insert(0, 1000); //Insert the value 1000 at rank 0

            for (int i = 0; i < repetitions; i++)
            {
                sw.Start();
                arrayBasedVector.Add(-1); // This is the operations to time
                sw.Stop();

                // Cleanup code, to keep the array at the some size
                arrayBasedVector.RemoveAt(arrayBasedVector.Count - 1); // since we have added 1 element,
                                                                       //we need to remove 1 element
                                                                       //it is faster to remove  the last






                //onsole.WriteLine("For a problem size of {0}", size);
                Console.WriteLine("The total time for carrying {0} operations takes {1} ticks", repetitions, sw.ElapsedTicks);
                Console.WriteLine("The mean (average) time for carrying a single  operations is {0} ticks", (double)sw.ElapsedTicks / repetitions);
            }
            Console.ReadKey();
        }
    }
}
