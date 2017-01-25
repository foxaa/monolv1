using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentIdGenerator
    {
        int ID = 0;
        private static StudentIdGenerator Instance;
        private StudentIdGenerator() { }
        public static StudentIdGenerator Inst
        {
            get
            {
                if(Instance==null)
                {
                    Instance = new StudentIdGenerator();

                }
                return Instance;
            }
        }
        public int IncId()
        {
            return ID++;
        }
    }
}
