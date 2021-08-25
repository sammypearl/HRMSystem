using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.IdentityModel
{
    public class AppUser
    {
        public AppUser() : base()
        {

        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Title { get; set; }
        public string MobileNo { get; set; }
        public string Language { get; set; }
        public string Company { get; set; }
        public Dept? Department { get; set; }
        public string JobTitle { get; set; }
        public string HomePhone { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifyBy { get; set; }
        

    }
}
