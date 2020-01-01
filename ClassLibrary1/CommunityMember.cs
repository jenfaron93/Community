using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
   public class CommunityMember
   {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string SocialSecurity { get; set; }


      public virtual string PrintInformation() =>
         $"Community member: {FirstName} {LastName}\n" +
         $"Social Security Number: {SocialSecurity}";

   }
}
