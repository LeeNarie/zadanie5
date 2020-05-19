using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {

            Student Andrey = new Student();
            Andrey.AddStudent(1, "Иванов Андрей Владимирович", "19-11-2", "25.12.2001");
            Andrey.ChangeGroup("19-11-1");
            Andrey.StudentWrite();
            Andrey.RemoveStudent();
            Andrey.StudentWrite();
            Console.ReadKey();
        }
    }
}
