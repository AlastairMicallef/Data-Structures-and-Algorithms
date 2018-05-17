using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Data
{
    class SetDS : SetADT
    {
        //An array to hold the data in the set
        private int[] setOfNumbers;
        public int[] SetOfNumbers { get => setOfNumbers; set => setOfNumbers = value; }

        //Allows the set of numbers to be received from the main program
        public SetDS(int[] set)
        {
            setOfNumbers = set;
        }

        public int Count(int i)
        {
            //Keep track of how many time i was found in the set
            int counter = 0;
            //Go throigh each amf every number
            foreach(int number in setOfNumbers)
            {
                //Check if number is equal to i
                if (number == 1)
                {
                    //If yes, increment counter
                    counter++;
                }
            }
            //retunr the number of times i was found i.e counter
            return counter;
        }

        public SetADT Union(SetADT s)
        {
            //Change the setADT to a setDS
            SetDS set2 = (SetDS)s;
            //Determine the size of the union set
            int size = this.setOfNumbers.Length + set2.setOfNumbers.Length; 
            //Create the array to holf the union of the 2 sets
            int[] unionSet = new int[size];

            //copy the elemenst of thix set into the union set
            for(int i = 0; i < this.setOfNumbers.Length; i++)
            {
                unionSet[i] = this.setOfNumbers[i];
            }

            //copy the element of the second set starting from the next avaible pos in the union set
            for (int j = this.setOfNumbers.Length; j < unionSet.Length; j++)
            {
                unionSet[j] = setOfNumbers[j - this.setOfNumbers.Length];
            }

            //Create a sert based on the unionset array
            SetDS unionOfSets = new SetDS(unionSet);

            return unionOfSets;
        }
    }
}
