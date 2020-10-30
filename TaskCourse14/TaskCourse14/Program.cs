using System;

namespace TaskCourse14
{
    class Program
    {
        static void Main(string[] args)
        {
            Human obj = new Human(0,"Ирина");
            Console.WriteLine(obj.Show_children());
        }
    }
}
