using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeberTracker.Models
{
   public class Person:IAudit 
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public string MailingAddressLines { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0}, {1} {2} {3}", LastName, FirstName, MiddleName,Suffix).Trim();
            }
        }
    }

}
