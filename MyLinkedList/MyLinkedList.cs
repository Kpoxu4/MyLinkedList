using System.Collections;


namespace MyLinkedList
{
    public class MyLinkedList<T> : IEnumerable
    {
      public Box<T>? Head {  get; private set; }
      
      public Box<T>? Tail { get; private set; }

      public int Count { get; private set; }

        public MyLinkedList()
        {
            Clear();
        }
        public MyLinkedList(T data)
        {
            var item = new Box<T>(data);
            Head = item;
            Tail = item;
            Count = 1;

        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new Box<T>(data);
                Tail.ValueNext = item;
                Tail = item;
                Count++;
            }
            else
            {
                AddFirstItem(data);
            }
        }
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.ValueNext;
                    Count--;
                    return;
                }

                var current = Head.ValueNext;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.ValueNext = current.ValueNext;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.ValueNext;
                }
            }

        }
        public void AppendHead(T data)
        {
            var item = new Box<T>(data)
            {
                ValueNext = Head
            };

            Head = item;
            Count++;
        }
        private void AddFirstItem(T data)
        {
            var item = new Box<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.ValueNext;
            }
        }
    }
}
