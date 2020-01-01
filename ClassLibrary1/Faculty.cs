using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
   public class Faculty:Employee
   {
      public double Salary { get; set; }

      public override string PrintInformation() =>
         $"Employee: {FirstName} {LastName} \n" +
         $"Salary: {Salary}";

      public override double Pay()
      {
         return Salary + PAY;
      }
   }
}
