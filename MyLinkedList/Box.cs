namespace MyLinkedList
{
    public class Box<T>
    {
        private T? data = default(T);

        public T? Data
        {
            get => data;

            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        public Box<T>? ValueNext { get; set; }

        public Box(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
