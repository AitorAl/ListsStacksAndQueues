using System;

namespace Common
{
    public class IntArrayList : IList
    {
        int[] Values;
        int NumElements = 0;

        public IntArrayList(int n)
        {
            //TODO #1: initialize Values with an array of size n
            Values = new int[n];
        }
        public string AsString()
        {
            string output = "[";

            for (int i = 0; i < Count(); i++)
                output += Values[i] + ",";
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #2: add a new integer to the end of the list

        }

        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            return Value(index);
        }


        
        public int Count()
        {
            //TODO #4: return the number of elements on the lis
            return NumElements;
        }


       
        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds2
            if(index > NumElements)
            {
                return;
            }
            while (index < NumElements)
            {
                Values[index] = Values(index + 1);
                index++;
            }
        }


        public void Clear()
        {
            //TODO #6: remove all the elements on the list
                NumElements = 0;
            
        }
    }
}