namespace ServicesV2
{
    public class Cabinet<T>
    {

        private List<T> _list = new List<T>();
        public void AddItem(T item)
        {
            _list.Add(item);
        }

        public void PrintAll()
        {
            Console.WriteLine($"There is/are {_list.Count} item(s) in the list");
            for (int i = 0; i < _list.Count; i++)
            {
                Console.WriteLine(_list[i]);
            }
        }
    }

    
}
