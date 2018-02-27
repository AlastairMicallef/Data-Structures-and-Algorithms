using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorExample
{
    /// <summary>
    /// Return the Abstract Data Type. Maintains an ordered sequence of Items of type T.
    /// </summary>
    interface IVectorADT<T>
    {

        ///<summary>
        ///Return the number of elemenst stored in the vector .
        ///</summary>
        ///<returns>Returns the number of elemenst stored in the vector.</returns>
        
        int Size();


        /// <summary>
        /// Returns the element found at rank r
        /// </summary>
        /// <param name="r">The rank r is the number of elements in front of the element to be returnd. Valid values of r are between 0 and Size() - 1, inclusise</param>
        /// <returns></returns>
        
        T GetElementAtRank(int r);

        T ReplaceElementAtRank(int r, T element);

        void InsertElememntAtRank(int r, T element);

        T RemoveElementAtRank(int r);

        ///<summary>
        ///Indexer used to provide the [] notation to the Vector ADT. The get is equivalent to the GetElementsATRAnk,
        ///while the set is similair to the ReplaceElementAtRank
        ///</summary>
        ///<param name="r">The rank that we are getting or setting</param>
        ///<returns>The item found at rank r</returns>
        ///

        T this[int r]
        {
            get;
            set;
        }
    }
}
