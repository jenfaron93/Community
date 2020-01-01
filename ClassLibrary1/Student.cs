using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
   public class Student:CommunityMember
   {

      public int studentID { get; set; }
      public int gpa { get; set; }

      public int Gpa
      {
         get
         {
            return gpa;
         }
         set
         {
            value = gpa;
         }
      }

      public int StudentID
      {
         get
         {
            return studentID;
         }
         set
         {
            if (value < 0 || value > 500000)
            {
               throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(StudentID)} must be < 0 and > than 500000");

            }

            value = studentID;
         }

      }


      public override string PrintInformation() =>
         $"Student: {FirstName} {LastName} \n StudentID: {studentID}\n" +
         $"Grade Point Average: {gpa}";
   }
}
