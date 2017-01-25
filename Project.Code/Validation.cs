using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class Validation
    {
        public bool Enlist;
        public bool Display;
        public bool ValidInput = false;
        public double Temp;

        public void CheckOperation(string operation)
        {
           Enlist = string.Equals(operation, Operations.OPERATION1, StringComparison.CurrentCultureIgnoreCase);
            Display = string.Equals(operation, Operations.OPERATION2, StringComparison.CurrentCultureIgnoreCase);
            if (!Enlist && !Display)
            {
                Console.WriteLine("Wrong operation name");
                ValidInput = false;
            }
            else if (String.IsNullOrEmpty(operation))
            {
                Console.WriteLine("Insert operation name:");
                ValidInput = false;
            }
            else
                ValidInput = true;

        }
        public void CheckInput(string input)
        {
       
            if(String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input incorrect");
                ValidInput = false;
            }
            else
            {
                ValidInput = true;
            }
        }
        public void CheckGPA(string gpa)
        {
            if(String.IsNullOrEmpty(gpa))
            {
                Console.WriteLine("Insert GPA value:");
                ValidInput = false;
            }
            else if (double.TryParse(gpa, out Temp) && Temp >= 2 && Temp <= 5)
            {
                ValidInput = true;
            }
            else
            {
                Console.WriteLine("Must insert a numerical value between 2 and 5.");
                ValidInput =false;
            }

        }

    }
}
