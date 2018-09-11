using System;

namespace Lab3
{
    public class SimpleStack<T> : SimpleList<T>
        where T : IComparable
    {
        public void Push(T item)
        {
            this.Add(item);
        }

        public T Pop()
        {
            var data = default(T);

            if (Count == 0)
            {
                return data;
            }
            else if (Count == 1)
            {
                data = last.data;
                first = last = null;
            }
            else
            {
                var newLast = this.GetItem(Count - 2);
                data = last.data;
                newLast.next = null;
                last = newLast;
            }
            
            Count--;
            return data;
        }
        
    }
}