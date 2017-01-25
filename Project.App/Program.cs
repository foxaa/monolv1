using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Code;

namespace Project.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation Val = new Validation();
            string Operation;
            bool Comp5 = true;
            do
            {
                do
                {
                    Comp5 = false;
                    Console.WriteLine("Insert operation:");
                    Operation = Console.ReadLine();
                    /*if(operation.Equals(Operations.operation1))
                    {
                        enlist();
                    }
                    else if(operation.Equals(Operations.operation2))
                    {
                        //display();
                    }
                    else 
                    {
                        Console.WriteLine("Wrong operation name.");
                        Console.WriteLine("Insert operation:");
                        operation = Console.ReadLine();
                    }*/
                    Val.checkOperation(Operation);
                    if (Val.Comp1) { Enlist(); }
                    else if (Val.Comp2) {
                        Display();
                        Comp5 = true;
                    }

                } while (!Val.Comp3);

            }while(!Comp5);
        }
        public static void Enlist()
        {
            Validation Val = new Validation();
            Student Stud = new Student();
            StudentContainer Stuc = StudentContainer.Inst;
            StudentIdGenerator SiD = StudentIdGenerator.Inst;
            string name;
            string surname;
            string gpa;
            do
            {
                Console.WriteLine("Insert name:");
                name = Console.ReadLine();
                Val.checkInput(name);

            } while (!Val.Comp3);
            do
            {
                Console.WriteLine("Insert surname:");
                surname = Console.ReadLine();
                Val.checkInput(surname);
            } while (!Val.Comp3);
            do
            {
                Console.WriteLine("Insert GPA:");
                gpa = Console.ReadLine();
                Val.checkGPA(gpa);
            } while (!Val.Comp3);
            Stud.Name = name;
            Stud.Surname = surname;
            Stud.Gpa = float.Parse(gpa);
            Stud.Id = SiD.incId();
            Stuc.AddStud(Stud);
        }
        public static void Display()
        {

            //Student stud = new Student();
            StudentContainer Stucos = StudentContainer.Inst;
            List<Student> People = Stucos.GetList();
            StudentIdGenerator Sid = StudentIdGenerator.Inst;

            
            //Console.WriteLine("dad");
            /*people.foreach(Student stud in people)
            {
                Console.WriteLine("dad");
                Console.WriteLine(stud.ToString());
                
            }*/
            //people.Sort();
            People.Sort(delegate (Student x, Student y)
                {
                    return x.Surname.CompareTo(y.Surname);
                });

            for (int i = 0; i < People.Count; i++)
            {
                Console.WriteLine(People[i].Id+ ". " + People[i].Name + ' ' + People[i].Surname + ' ' + People[i].Gpa);
            }
            //people.ForEach(Console.Write);
        }
    }
}
