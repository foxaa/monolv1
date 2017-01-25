using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Validation
    {
        public bool comp1;
        public bool comp2;
        public bool comp3 = false;
        public double a;

        public void checkOperation(string operation)
        {
            comp1 = string.Equals(operation, Operations.operation1, StringComparison.CurrentCultureIgnoreCase);
            comp2 = string.Equals(operation, Operations.operation2, StringComparison.CurrentCultureIgnoreCase);
            if (!comp1 && !comp2)
            {
                Console.WriteLine("Wrong operation name");
                comp3 = false;
            }
            else if (String.IsNullOrEmpty(operation))
            {
                Console.WriteLine("Insert operation name:");
                comp3 = false;
            }
            else
                comp3 = true;

        }
        public void checkInput(string input)
        {
       
            if(String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input incorrect");
                comp3 = false;
            }
            else
            {
                comp3 = true;
            }
        }
        public void checkGPA(string gpa)
        {
            if(String.IsNullOrEmpty(gpa))
            {
                Console.WriteLine("Insert GPA value:");
                comp3 = false;
            }
            else if (double.TryParse(gpa, out a) && a >= 1 && a <= 5)
            {
                comp3 = true;
            }
            else
            {
                Console.WriteLine("Must insert a numerical value.");
                comp3 =false;
            }

        }

    }
}
