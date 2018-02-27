using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorExample
{
    class ArrayBasedVector<T> : IVectorADT<T>
    {
        /// <summary>
        /// The sunmer of elements stored so far
        /// </summary>
        private int _size = 0;

        /// <summary>
        /// An array that will store the items in the ArrayBaseVector
        /// </summary>

        private T[] V = null;

        private const int DEFAULT_ARRAY_SIZE = 100;

        public ArrayBasedVector(int initialCapacity = DEFAULT_ARRAY_SIZE)
        {
            V = new T[initialCapacity];
        }

        public int Size()
        {
            return _size;
        }

        public T GetElementAtRank(int r)
        {
            #region Validation
            if (r < 0 || r>= _size)
            {
                throw new ArgumentOutOfRangeException("r", r, "The vaue of r, representing the rank, must be between 0 and size - 1, both include");
            }
            #endregion 

            return V[r];
        }


        public T this[int r]
        {
            get
            {
                return GetElementAtRank(r);
            }


            set
            {
                ReplaceElementAtRank(r, value);
            }

        }

      

        public void InsertElememntAtRank(int r, T element)
        {
            #region Validation
            if (r < 0 || r > _size)
            {
                throw new ArgumentOutOfRangeException("r", r, "The vaue of r, representing the rank, must be between 0 and size, both include");
            }

            if(_size >= V.Length)// the underlying array (V) in full
            {
                throw new NotImplementedException("The underlying array is full. Array grouth is not implemented yet..");
            }
            #endregion 

            //add element
            for (int i =_size - 1; i >=r; i--)
            {
                //copy the element to the next position
                V[i + 1] = V[1];
            }

            //an empty space is availble at position r, for the new element 
            V[r] = element;

            //After adding the element, we now have 1 more element stored
            _size++;
        }

        public T RemoveElementAtRank(int r)
        {
            throw new NotImplementedException();
        }

        public T ReplaceElementAtRank(int r, T element)
        {
            throw new NotImplementedException();
        }

       
    }
}
