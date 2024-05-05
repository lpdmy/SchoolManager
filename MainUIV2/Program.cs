using Repositories.Entities;
using ServicesV2;

namespace MainUIV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet<Student> seList = new Cabinet<Student>();
            seList.AddItem(new Student()
            {
                Name = "My",
                Email = "my@...",
                Gpa = 9.7,
                Id = "DE180283",
                Yob = 2004
            });
            seList.AddItem(new Student()
            {
                Name = "Quyen",
                Email = "quyen@...",
                Gpa = 9.5,
                Id = "DE183993",
                Yob = 2007
            });

            seList.PrintAll();
        }

        static void PlayWithIntegerList()
        {
            //int[] arr = new int[10];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4; 
            // arr là biến con trỏ, là biến tham chiếu, là biến trỏ vùng nhớ bự new int[10] 
            //JAVA : List <Integer> arr = new ArrayList<Integer>
            // Cấm new List vì list là interface
            //C#: LIST VÀ ARRAYLIST ĐỀU NEW ĐƯỢC
            // KHUYÊN DÙNG LIST, KO NÊN DÙNG ARRAYLIST VÌ KO AN TOÀN NẾU KO HIỂU RÕ VỀ NÓ
            //List<Student> List<int>
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            Console.WriteLine($"There is/are {list.Count} in the list/bag");
            Console.WriteLine("The integer list printed by using for i");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]); //xài như mảng [pos]: INDEXER
            }
            Console.WriteLine("The integer list printed by using for i");
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}
