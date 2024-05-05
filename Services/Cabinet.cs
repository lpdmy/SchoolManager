namespace Services
{
    public class Cabinet<T>// COI DATATYPE LÀ THAM SỐ TRUYỀN VÀO
    {
        private T[] _list = new T[300];
        private int _count = 0;

        public void AddItem(T item)
        {
            //TODO : check tràn mảng throw OutOfBoundary Exception
            _list[_count++] = item;
            
        }
        public void PrintAll()
        {
            // chơi với mảng ko for đến cuối
            Console.WriteLine($"There is/are {_count} items in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]); //toString() implicitly
            }
            
        }
    }
}
