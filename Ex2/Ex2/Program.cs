using System;
using System.Collections.Generic;


namespace Ex2
{
    public class Student
    {
        private string Name;

        public virtual void Study()
        {

        }
        public virtual void Read()
        {

        }
        public virtual void Write()
        {

        }
        public virtual void Relax()
        {

        }
        public Student(string newName)
        {
            Name = newName;
        }

        public string GetName()
        {
            return Name;
        }
    }

    public class GoodStudent :Student
    {
        public GoodStudent(string newName) : base(newName)
        {
            
        }
        public override void Study()
        {
            Console.Write("Excellent ");
        }
        public override void Read()
        {
            Console.Write("Good ");
        }
        public override void Write()
        {
            Console.Write("Nice ");
        }
        public override void Relax()
        {
            Console.Write("Not bad ");
        }
    }
    public class BadStudent : Student
    {
        public BadStudent(string newName) : base(newName)
        {
        }
        public override void Study()
        {
            Console.Write("Could be better ");
        }
        public override void Read()
        {
            Console.Write("Well but wrong books ");
        }
        public override void Write()
        {
            Console.Write("Grammar? ");
        }
        public override void Relax()
        {
            Console.Write("AMAZING ");
        }
    }

    class Group
    {
        private List<Student> ListOfStudents = new List<Student>(0);
        public Group(string name1, string name2, string name3)
        {
            Random rand = new Random();
            List<string> Names = new List<string>(){ name1, name2, name3 };
            for (int i = 0; i < 3; i++)
            {
                int randomBool = rand.Next(2);
                if (randomBool == 1)
                {
                    GoodStudent TempStudent = new GoodStudent(Names[i]);
                    ListOfStudents.Add(TempStudent);
                }
                else
                {
                    BadStudent TempStudent = new BadStudent(Names[i]);
                    ListOfStudents.Add(TempStudent);
                }
            }
        }

        public void ShowGroup()
        {
            foreach (Student S in ListOfStudents)
            {
                Console.WriteLine(S.GetName() + " ");
                Console.Write("Study: "); S.Study(); Console.WriteLine();
                Console.Write("Read: "); S.Read(); Console.WriteLine();
                Console.Write("Write: "); S.Write(); Console.WriteLine();
                Console.Write("Relax: "); S.Relax(); Console.WriteLine();
                Console.WriteLine("_____________________________");
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Group K24 = new Group("SonyaandVasya", "Vasyl", "Sonya");
            K24.ShowGroup();
        }
    }
}
