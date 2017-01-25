using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentIdGenerator
    {
        int id = 0;
        private static StudentIdGenerator instance;
        private StudentIdGenerator() { }
        public static StudentIdGenerator Inst
        {
            get
            {
                if(instance==null)
                {
                    instance = new StudentIdGenerator();

                }
                return instance;
            }
        }
        public int incId()
        {
            return id++;
        }
    }
}
