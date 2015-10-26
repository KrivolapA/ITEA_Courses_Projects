using System;


namespace Lesson3
{
    class Student
    {
        public string FirstName = "Ivan";
        public string LastName = "Ivanov";
        private byte age = 18;

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public int Id { get; set; }
        public byte Age
        {
            get
            {
                Console.WriteLine("Get");
                return age;
            }
            set
            {
                Console.WriteLine("Set");
                if (value > 150)
                    Console.WriteLine("Incorect value");
                else
                    age = value;
            }
        }

        private int points = 10;

        public int Points
        {
            get { return points; }
            set
            {
                if (value >= 0 && value <= 100) points = value;
                else
                {
                    Console.WriteLine("Incorect points");
                }
            }
        }

        public string Company = "ThisCompany";

        public string FullInfo
        {
            get { return FullName + " company " + Company + " has " + Points; }
        }

        public Student(string FirstName, string LastName , byte Age, int Points, string Company)
        {
            Console.WriteLine("Student ctor");
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Points = Points;
            this.Company = Company;
        }

        public Student(string FirstName, string LastName) : this(FirstName, LastName, 18, 10, "MyCompany")
        {}
        public Student()
        {
            
        }

       /* public static Student CreateStudent()
        {
            return  new Student();
        }*/
    }
}


