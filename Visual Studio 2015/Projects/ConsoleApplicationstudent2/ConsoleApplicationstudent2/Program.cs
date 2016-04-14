using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationstudent2
{
    class Program
    {
        static void Main(string[] args)

        {
            Student student1 = new Student();
            student1.PrintMethod();
           
        }

    }

    class Student
    {
        //fields
       public string course;           
       public string subject;
       public string university;
       public string email;
       public string phonenumber;
       public string fullname;


        public Student()
        {
            this.fullname ="niki";
            this.course = "ELA";
            this.subject = "ElA1";
            this.university = "CSU";
            this.email = "ndmouse@gmail.com";
            this.phonenumber = "2163334555";

        }
        
        public Student(string fullname)
        {
            this.fullname = fullname;//"Sara Beatrice";
            

        }
        public Student(string course, string subject)
        {
            this.course = course;
            this.subject = subject;

        }
        public Student(string university, string email, string course)
        {
            this.university = university;
            this.email = email;
            this.course = course;

        }
        public Student(string fullname, string email, string phonenumber,string university)
        {
            this.fullname = fullname;
            this.email = email;
            this.phonenumber = phonenumber;
            this.university = university;
        }
        public void PrintMethod()
        {
                   
            Console.WriteLine(this.fullname);
            Console.WriteLine(this.phonenumber);
            Console.WriteLine(this.email);
            Console.WriteLine(this.university);
            Console.WriteLine(this.course);
            Console.WriteLine(this.subject);
         

        }
    }
}
