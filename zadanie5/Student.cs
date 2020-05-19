using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace zadanie5
{
    class Student
    {
        static private int id;
        static private string Fio;
        static private string group;
        static string data;

        public ArrayList studinfo = new ArrayList() { Id, FIO, Group, Data };
        static public  int Id
        {
            get
            {
                return id;
            }

            set
            {
               if (value>=0) id = value;
            }
        }

        static public string FIO
        {
            get
            {
                return Fio;
            }

            set
            {
                if (!value.Trim().Equals("")) Fio = value;
            }
        }

        static public string Group
        {
            get
            {
                return group;
            }

            set
            {
                if (!value.Trim().Equals("")) group = value;
            }
        }

        static public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public void AddStudent(int id,string Fio, string group,string data)
        {

            studinfo[0] = id;
            studinfo[1] = Fio;
            studinfo[2] = group;
            studinfo[3] = data;
        }

        public void StudentWrite()
        {
            foreach (object o in this.studinfo)
            {
                Console.WriteLine(o + " ");
            }
        }
        public void ChangeId(int id)
        {
            studinfo[0] = id;
        }

         public void ChangeFio(string Fio)
        {
            studinfo[1] = Fio;
        }
         public void ChangeGroup(string group)
        {
            studinfo[2] = group;
        }
         public void ChangeData(string data)
        {
            studinfo[3] = data;
        }

         public void RemoveStudent()
        {
            this.studinfo.Clear();
        }
    }
}
