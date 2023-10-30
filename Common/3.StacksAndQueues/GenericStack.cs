
namespace Common
{
    public class GenericStack<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        //public GenericList<T> myList = new GenericList<T>();
        public GenericArrayList<T> myList = new GenericArrayList<T>(40000);
        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list
            return myList.AsString();
            
        }

        public int Count()
        {
            //TODO #3: Return the number of objects
            return myList.Count();
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
             myList.Clear();
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
             myList.Add(value);
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it
            T aux = myList.Get(myList.Count()-1);
            myList.Remove(myList.Count() - 1);
            return aux;
        }
    }
}