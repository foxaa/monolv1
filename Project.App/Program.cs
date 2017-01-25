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
            Validation val = new Validation();
            string operation;
            bool comp5 = true;
            do
            {
                do
                {
                    comp5 = false;
                    Console.WriteLine("Insert operation:");
                    operation = Console.ReadLine();
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
                    val.checkOperation(operation);
                    if (val.comp1) { enlist(); }
                    else if (val.comp2) {
                        display();
                        comp5 = true;
                    }

                } while (!val.comp3);

            }while(!comp5);
        }
        public static void enlist()
        {
            Validation val = new Validation();
            Student stud = new Student();
            StudentContainer stuc = StudentContainer.Inst;
            StudentIdGenerator SiD = StudentIdGenerator.Inst;
            string name;
            string surname;
            string gpa;
            do
            {
                Console.WriteLine("Insert name:");
                name = Console.ReadLine();
                val.checkInput(name);

            } while (!val.comp3);
            do
            {
                Console.WriteLine("Insert surname:");
                surname = Console.ReadLine();
                val.checkInput(surname);
            } while (!val.comp3);
            do
            {
                Console.WriteLine("Insert GPA:");
                gpa = Console.ReadLine();
                val.checkGPA(gpa);
            } while (!val.comp3);
            stud.name = name;
            stud.surname = surname;
            stud.gpa = float.Parse(gpa);
            stud.id = SiD.incId()-33;
            stuc.AddStud(stud);
        }
        public static void display()
        {

            //Student stud = new Student();
            StudentContainer stucos = StudentContainer.Inst;
            List<Student> people = stucos.GetList();
            StudentIdGenerator sid = StudentIdGenerator.Inst;

            
            //Console.WriteLine("dad");
            /*people.foreach(Student stud in people)
            {
                Console.WriteLine("dad");
                Console.WriteLine(stud.ToString());
                
            }*/
            //people.Sort();
            people.Sort(delegate (Student x, Student y)
                {
                    return x.surname.CompareTo(y.surname);
                });

            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].id + ' ' + people[i].name + ' ' + people[i].surname + ' ' + people[i].gpa);
            }
            //people.ForEach(Console.Write);
        }
    }
}
