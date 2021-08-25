using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EmpEmergCall
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string RelationTo { get; set; }
        public string Phone { get; set; }

        public Employee Employee { get; set; }
    }
}
