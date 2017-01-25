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
            return SortList(Student);
        }
        public List<Student> SortList(List<Student> stud)
        {
            /*stud.Sort(delegate (Student x, Student y)
             {
                 return x.Surname.CompareTo(y.Surname);
             }); */
            return stud.OrderBy(a => a.Surname).ToList();
            //stud.Sort((x, y) => string.Compare(x.Surname, y.Surname));

        }
    }
}
