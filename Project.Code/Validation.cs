using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Validation
    {
        public bool Comp1;
        public bool Comp2;
        public bool Comp3 = false;
        public double Temp;

        public void checkOperation(string operation)
        {
            Comp1 = string.Equals(operation, Operations.Operation1, StringComparison.CurrentCultureIgnoreCase);
            Comp2 = string.Equals(operation, Operations.Operation2, StringComparison.CurrentCultureIgnoreCase);
            if (!Comp1 && !Comp2)
            {
                Console.WriteLine("Wrong operation name");
                Comp3 = false;
            }
            else if (String.IsNullOrEmpty(operation))
            {
                Console.WriteLine("Insert operation name:");
                Comp3 = false;
            }
            else
                Comp3 = true;

        }
        public void checkInput(string input)
        {
       
            if(String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input incorrect");
                Comp3 = false;
            }
            else
            {
                Comp3 = true;
            }
        }
        public void checkGPA(string gpa)
        {
            if(String.IsNullOrEmpty(gpa))
            {
                Console.WriteLine("Insert GPA value:");
                Comp3 = false;
            }
            else if (double.TryParse(gpa, out Temp) && Temp >= 1 && Temp <= 5)
            {
                Comp3 = true;
            }
            else
            {
                Console.WriteLine("Must insert a numerical value.");
                Comp3 =false;
            }

        }

    }
}
