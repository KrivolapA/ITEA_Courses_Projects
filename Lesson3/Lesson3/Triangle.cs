using System;


namespace Lesson3
{
    class Triangle
    {
        private int a = 5;
        private int b = 4;
        private int c = 3;
        private bool isRight = true;

        public bool IsRight
        {
            get { return isRight; }
        }

        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("wrong value A");
                else if (value + b <= c || value + c <= b || c + b <= value)
                    Console.WriteLine("wrong value A");
                else
                {
                    a = value;
                    isRight = a*a + b*b == c*c || c*c + b*b == a*a || a*a + c*c == b*b;
                }
            }
        }
    }
}
