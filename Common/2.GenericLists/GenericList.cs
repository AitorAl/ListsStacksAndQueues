using Common;

public class GenericListNode<T>
{
    public T Value;
    public GenericListNode<T> Next = null;

    public GenericListNode(T value)
    {
      Value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
}

public class GenericList<T> : IGenericList<T>
{
    GenericListNode<T> First = null;

    public string AsString()
    {
      GenericListNode<T> node = First;
      string output = "[";

      while (node != null)
      {
        output += node.ToString() + ",";
        node = node.Next;
      }
      output = output.TrimEnd(',') + "] " + Count() + " elements";
      
      return output;
    }

    public void Add(T value)
    {
        //TODO #1: add a new element to the end of the list
        GenericArrayList<T> currentNode = First;
        GenericArrayList<T> listNode = new GenericArrayList<T>(value);
        if (currentNode == null)
        {
            First = listNode;
        }
        else
        {
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = listNode;
        }
    }

    public GenericListNode<T> FindNode(int index)
    {
        //TODO #2: Return the element in position 'index'

        int currentPos = 0;
        GenericArrayList<T> currentNode = First;
        while (currentPos < index && currentNode != null)
        {
            currentNode = currentNode.Next;
            currentPos++;
        }
        if (currentPos == index)
            return currentNode;
        return null;
    }

    public T Get(int index)
    {
        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds

        if (index < 0 || index >= Count())
        {
            return 0;
        }
        IntListNode x = GetNode(index);
        return x.Value;
    }

    public int Count()
    {
        //TODO #4: return the number of elements on the list

        int pos = 0;
        GenericArrayList<T> currentNode = First;
        if (currentNode != null)
        {
            pos++;
        }
        else
        {
            return pos = 0;
        }

        while (currentNode.Next != null)
        {
            currentNode = currentNode.Next;
            pos++;
        }
        return pos;
    }


    public void Remove(int index)
    {
        //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
        GenericArrayList<T> currentNode = First;

        if (index == 0 && currentNode != null)
        {
            First = currentNode.Next;
        }
        while (currentNode.Next != null && index > 1)
        {
            currentNode = currentNode.Next;
            index--;
        }
        if (index == 1)
        {
            currentNode.Next = currentNode.Next.Next;
        }
    }

    public void Clear()
    {
        //TODO #6: remove all the elements on the list
        First = null;
    }
}