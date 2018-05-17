using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST_Revision
{
    class SetDS : SetADT
    {
        //An array to hold the data in the set
        private int[] setOfNumbers;
        public int[] SetOfNumbers { get => setOfNumbers; set => setOfNumbers = value; }

        //Allows the set of numbers to be received from the main program
        public SetDS(int[] set)
        {
            SetOfNumbers = set;
        }


        public int Count(int i)
        {
            //Keep track of how many time i was found in the set
            int counter = 0;
            //Go through each of the every number
            foreach(int number in setOfNumbers)
            {
                if(number == i)
                {
                    //If yes, increment counter
                    counter++;
                }
            }
            return counter;
        }

        public SetADT Union(SetADT s)
        {
            //Chnage the setADT to a setDS
            SetDS set2 = (SetDS)s;
            //Determine the size of the union set
            int size = this.setOfNumbers.Length + set2.setOfNumbers.Length;
            //Create the array to half the union of the 2 sets
            int[] unionSet = new int[size];

            //Copy the elemenst of this setinto the union set
            for(int i = 0; i <this.setOfNumbers.Length; i++)
            {
                unionSet[i] = this.setOfNumbers[i];
            }

            //Copy the elements of the second set starting from the next availble pos in the union set
            for (int j = this.setOfNumbers.Length; j < unionSet.Length; j++)
            {
                unionSet[j] = setOfNumbers[j - this.setOfNumbers.Length];
            }

            //Create a sort based on the unionset array
            SetDS unionOfSets = new SetDS(unionSet);

            return unionOfSets;
        }
    }
}
