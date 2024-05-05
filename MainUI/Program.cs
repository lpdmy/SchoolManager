using Repositories.Entities;
using Services;

namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LƯU DANH SÁCH NGÀY SE RIÊNG BIỆT, NGÀNH BIZ RIÊNG BIỆT
            // DANH SÁCH GV RIÊNG BIỆT
            Cabinet<Student> seList = new Cabinet<Student>();
            Cabinet<Student> bizList = new Cabinet<Student>();
            Cabinet<Lecturer> seLecList = new Cabinet<Lecturer>();
            // 2 SE
            seList.AddItem(new Student()
            {
                Id = "SE1",
                Name = "An",
                Gpa = 9.6,
                Email = "an@...",
                Yob = 2004
            });
            seList.AddItem(new Student()
            {
                Id = "SE2",
                Name = "Binh",
                Gpa = 5.6,
                Email = "binh@...",
                Yob = 2003
            });
            //1 biz
            bizList.AddItem(new Student()
            {
                Id = "BE1",
                Name = "Cuong",
                Gpa = 4.3,
                Email = "cuong@...",
                Yob = 2005
            });
            // 2 GV
            seLecList.AddItem(new Lecturer() { Id = "000000001", Name = "Dung", Email = "dung@...", Yob = 1994 });
            seLecList.AddItem(new Lecturer() { Id = "000000002", Name = "Em", Email = "em@...", Yob = 1992 });

            //in all info

            Console.WriteLine("The SE student list");
            seList.PrintAll();

            Console.WriteLine("The Biz student list");
            bizList.PrintAll();

            Console.WriteLine("The SE lecturer list");
            seLecList.PrintAll();
        }
    }
}
