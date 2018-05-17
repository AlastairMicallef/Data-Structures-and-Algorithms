using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST_Revision
{
    interface SetADT
    {
        ///<summary>
        ///returns how many time i is present in a set
        ///</summary>
        ///<param name="i">number to count instance</param>
        ///<returns>number of time i is present</returns>
        ///
        int Count(int i);

        ///<summary>
        ///Joins the contents of this set with those of set s
        /// </summary>
        /// <param name="s">the set to join with</param>
        /// <retuns>SetADT contains the elemenst of this set and set s</retuns>
        /// 
        SetADT Union(SetADT s);

    }
}
