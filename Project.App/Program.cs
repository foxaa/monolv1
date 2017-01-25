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
            bool IsDisplay = true;
            do
            {
                    IsDisplay = false;
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
                    Val.CheckOperation(Operation);
                    if (Val.Enlist) { Enlist(); }
                    else if (Val.Display) {
                        Display();
                        IsDisplay = true;
                    }

            }while(!IsDisplay);
        }

        /*public static void Mock()
        {
            Validation Val = new Validation();
            StudentContainer Stuc = StudentContainer.Inst;
            StudentIdGenerator SiD = StudentIdGenerator.Inst;

            for(int i = 0; i < 5; i++)
            {
                Student s = new Student()
                {
                    Id = SiD.incId(),
                    Name = "name"+i,
                    Surname = "surname"+i,
                };
                Stuc.AddStud(s);
            }
            
        }*/

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
                Val.CheckInput(name);

            } while (!Val.ValidInput);
            do
            {
                Console.WriteLine("Insert surname:");
                surname = Console.ReadLine();
                Val.CheckInput(surname);
            } while (!Val.ValidInput);
            do
            {
                Console.WriteLine("Insert GPA:");
                gpa = Console.ReadLine();
                Val.CheckGPA(gpa);
            } while (!Val.ValidInput);
            Stud.Name = name;
            Stud.Surname = surname;
            Stud.Gpa = float.Parse(gpa);
            Stud.Id = SiD.IncId();
            Stuc.AddStud(Stud);
        }
        public static void Display()
        {

            //Student stud = new Student();
            StudentContainer StuContain = StudentContainer.Inst;
            List<Student> People = StuContain.GetList();
            // StudentIdGenerator Sid = StudentIdGenerator.Inst;


            //Console.WriteLine("dad");
            /*people.foreach(Student stud in people)
            {
                Console.WriteLine("dad");
                Console.WriteLine(stud.ToString());
                
            }*/
            //people.Sort();
            /*People.Sort(delegate (Student x, Student y)
                {
                    return x.Surname.CompareTo(y.Surname);
                });*/
            //Stucos.SortList(People);
            
            for (int i = 0; i < People.Count; i++)
            {
                Console.WriteLine(People[i].Id+ ". " + People[i].Name + ' ' + People[i].Surname + ' ' + People[i].Gpa);
            }
            //people.ForEach(Console.Write);
        }
    }
}
