using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student one = new ITStudent();
            one.G1 = 12;
            one.G2 = 54;
            one.G3 = 36;

            Console.WriteLine("Grades : {0}%, {1}%, {2}%.", one.G1, one.G2, one.G3);
            Console.WriteLine("The sum of the grades is {0}", one.GradeSum());
            Console.ReadLine();
        }
    }

    class Student
    {
        public int G1 { get; set; }
        public int G2 { get; set; }
        public int G3 { get; set; }

    }

    class ITStudent : Student
    {
         public virtual int GradeSum()
        {
            int sum = G1 + G2 + G3;
            return sum;
        }
    }

    public class BusinessStudent : Student
    {
        
    }
}
