using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community;

namespace CommunityTest
{
   class Program
   {
      static void Main(string[] args)
      {
         CommunityMember x = new CommunityMember();
         x.FirstName = "Bob";
         x.LastName = "Joney";
         x.SocialSecurity = "999-99-9999";
         Console.WriteLine("The member class info is: \n" + x.PrintInformation());

         Employee y = new Employee();
         y.FirstName ="Brittany";
         y.LastName = "Jones";
         y.EmployeeID = "1111";
         y.PrintInformation();

         Faculty z = new Faculty();
         z.FirstName = ("Joe");
         z.LastName = ("Brittany");
         z.Salary = 3000;
         z.PrintInformation();
         

         Staff a = new Staff();
         a.PayRate = 17;
         a.Hours = 40;
         a.PrintInformation();

         Student b = new Student();
         b.FirstName = "Mary";
         b.LastName = "Joe";
         b.StudentID = 111;
         b.PrintInformation();
      
      }
   }
}
