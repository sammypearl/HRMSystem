using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.IdentityModel
{
    public class AppRole
    {
        public AppRole() : base()
        {

        }

        //  public int RoleId { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }


    }
}
