using Sets_Ex_211.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sets_Ex_211
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Students stu = new Students();

                Console.Write("How many students for the course A: ");
                int n = int.Parse(Console.ReadLine());
                stu.Quantity(n);

                Console.Write("How many students for the course B: ");
                n = int.Parse(Console.ReadLine());
                stu.Quantity(n);
                
                Console.Write("How many students for the course C: ");
                n = int.Parse(Console.ReadLine());
                stu.Quantity(n);


                Console.WriteLine(stu);

            }
            catch (IOException)
            {
                throw new IOException("The type value is not correct");
            }
        }
    }
}










