using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorExample
{
    class Program
    {
        static void Main(string[] args)
        {

            IVectorADT<String> myVector = new ArrayBasedVector<String>();

            myVector.InsertElememntAtRank(0, "A");
            myVector.InsertElememntAtRank(1, "B");
            myVector.InsertElememntAtRank(2, "C");
            myVector.InsertElememntAtRank(3, "D");
            myVector.InsertElememntAtRank(4, "F");

            myVector.InsertElememntAtRank(2, "C");

            IVectorADT<string> myOtherVector = new ArrayBasedVector<String>(10);

            Console.ReadKey();

            //myVector[0] = 5;
            

        }
    }
}
