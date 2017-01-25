using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentIdGenerator
    {
        private int id = 0;
        private static StudentIdGenerator instance;
        private StudentIdGenerator() { id = 1; }
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
