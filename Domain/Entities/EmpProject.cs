using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{ 
    public class EmpProject
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }
        public string Completed { get; set; }
        public string JobPosition { get; set; }
        public int ProjectId { get; set; }
        public string Notes { get; set; }

        public Employee Employee { get; set; }
    }
}
