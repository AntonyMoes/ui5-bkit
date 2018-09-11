namespace Lab3
{
    public class SimpleListItem<T>
    {
        public T data { get; set; }
        
        public SimpleListItem<T> next { get; set; }
        
        public SimpleListItem(T param)
        {
            this.data = param;
        }
    }
}