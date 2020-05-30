using System;
using System.Collections.Generic;
using System.Text;

namespace Sets_Ex_211.Entities
{
    class Students
    {
        public int Code { get; set; }
        public int N { get; set; }
        HashSet<int> set = new HashSet<int>();

        public Students()
        {
        }

        public Students(int code, int n)
        {
            Code = code;
            N = n;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }


        public void Quantity(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Code = int.Parse(Console.ReadLine());
                set.Add(Code);

            }

        }

        public override string ToString()
        {
            return "Total students: " + set.Count;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Students))
            {
                throw new Exception("The student doesn't belong to any course!");
            }

            Students other = obj as Students;
            return Code.Equals(other.Code);
        }
    }
}