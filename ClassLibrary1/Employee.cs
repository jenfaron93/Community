using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
   public class Employee:CommunityMember
   {
      protected const double PAY = 500.0;
      public string EmployeeID { get; set; }

      public virtual double Pay()
      {
         return PAY;
      }

      public override string PrintInformation()
      {
         return $"Employee name is {FirstName} {LastName} and ID is {EmployeeID}";
      }

   }
}
