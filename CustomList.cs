using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        //member variables
        private T[] myCustomArray;
        private int count;
        private int capacity;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public T this[int i]
        {
            get
            {
                return myCustomArray[i];
            }
            set
            {
                myCustomArray[i] = value;
            }
        }


        // constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            myCustomArray = new T[capacity];
        }


        // member methods

        //ADD
        public void Add(T numberAdded)
        {
            if (capacity == count)
            {
                T[] temporaryArray = new T[capacity];
                temporaryArray = myCustomArray;
                myCustomArray = new T[capacity *= 2];
                for (int i = 0; i < temporaryArray.Length; i++)
                {
                    myCustomArray[i] = temporaryArray[i];
                }




            }
            myCustomArray[Count] = numberAdded;
            Count++;
        }

        /// REMOVE
        public bool Remove(T itemToRemove)
        {
            T[] temporaryArray = new T[capacity];
            bool itemFound = false;
            for (int i = 0; i < myCustomArray.Length; i++)
            {

                if (!myCustomArray[i].Equals(itemToRemove) && itemFound == false)
                {
                    if (itemFound == false)
                    {
                        temporaryArray[i] = myCustomArray[i];

                    }

                }

                else if (myCustomArray[i].Equals(itemToRemove) && itemFound == false)
                {

                    itemFound = true;
                    continue;
                }
                else
                {
                    temporaryArray[i - 1] = myCustomArray[i];
                }

            }
            myCustomArray = temporaryArray;

            if (itemFound)
            {
                count--;
            }
            return true;
        }


    }
}
