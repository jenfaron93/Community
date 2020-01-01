using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
   public class Staff:Employee
   {
      public int PayRate { get; set; }
      public int Hours { get; set; }

      public override double Pay()
      {
         return PayRate * Hours + PAY;
      }

      public override string PrintInformation() =>
         $"Employee: {FirstName} {LastName}";
   }
}
