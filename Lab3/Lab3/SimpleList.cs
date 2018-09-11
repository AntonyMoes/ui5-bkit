using System;
using System.Collections;

namespace Lab3
{
    public class SimpleList<T> : IEnumerable
        where T : IComparable
    {
        protected SimpleListItem<T> first = null;
        protected SimpleListItem<T> last = null;

        public int Count { get; protected set; } = 0;

        public void Add(T data)
        {
            if (first == null)
            {
                first = new SimpleListItem<T>(data);
                last = first;
            }
            else
            {
                last.next = new SimpleListItem<T>(data);
                last = last.next;
            }
            Count++;
        }

        public SimpleListItem<T> GetItem(int n)
        {
            if (n < 0 || n >= Count)
            {
                throw new IndexOutOfRangeException($"Current index: {n} is out of List's range");
            }

            int i = 0;
            SimpleListItem<T> current = first;

            while (i < n)
            {
                current = current.next;
                i++;
            }

            return current;
        }

        public T Get(int n)
        {
            return this.GetItem(n).data;
        }
        
        public IEnumerator GetEnumerator()
        {
            var current = first;
            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }

        public void Sort()
        {
            this.Sort(0, Count - 1);
        }

        private void Sort(int low, int high)
        {
            int i = low;
            int j = high;
            T x = Get((low + high) / 2);
            do
            {
                while (Get(i).CompareTo(x) < 0) ++i;
                while (Get(j).CompareTo(x) > 0) --j;
                if (i <= j)
                {
                    Swap(i, j);
                    i++; j--;
                }
            } while (i <= j);
            if (low < j) Sort(low, j);
            if (i < high) Sort(i, high);;
        }
        
        private void Swap(int i, int j)
        {
            SimpleListItem<T> ci = GetItem(i);
            SimpleListItem<T> cj = GetItem(j);
            T temp = ci.data;
            ci.data = cj.data;
            cj.data = temp;
        }
    }
}