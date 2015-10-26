using System;


namespace Lesson3
{

    partial class Program
    {
        static void Main()
        {
            Student st = new Student("John", "Smith");
            Student st2 = new Student("A", "B");
            Student st3 = new Student{FirstName =  "I", Company =  "This Company"};
            st.Age = 10;
            var n = new {N = "a", b = 12};
            var m = new { N = "c", b = 11 };
            n = m;
            //st.FullName = "A";
            Console.WriteLine(st.FullInfo);
            Console.WriteLine(st2.FullInfo);
            Console.WriteLine(st3.FullInfo);
            Console.Read();
        }
    }
}
