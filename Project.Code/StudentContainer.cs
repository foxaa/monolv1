using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentContainer
    {
        List<Student> Student = new List<Student>();
        private static StudentContainer instance;
        private StudentContainer() { }
        
        public static StudentContainer Inst //singleton patern
        {
          get
                {
                if(instance==null)
                {
                    instance = new StudentContainer();
                }
                return instance;
            }
        }

        public void AddStud(Student stud)
        {
            Student.Add(stud);
        }
        public List<Student> GetList()
        {
            return Student;
        }
    }
}
