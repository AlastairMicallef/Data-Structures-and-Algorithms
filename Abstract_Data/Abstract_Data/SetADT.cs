using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Data
{
    interface SetADT
    {

        /// <summary>
        /// returns how many time i is present in a set 
        /// </summary>
        /// <param name="i">number to count instances</param>
        /// <returns>number of time i is present</returns>
        
        int Count(int i);

        /// <summary>
        /// Joins the contents of this set with those of set s
        /// </summary>
        /// <param name="s">the set to join with</param>
        /// <returns>SetADT containt the elemenst of this set and set s///</returns>
        SetADT Union(SetADT s);

    }
}
