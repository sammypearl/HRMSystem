using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EmpEducation
    {
        public int EmployeeId { get; set; }
        public string Department { get; set; }
        public int DegreeId { get; set; }
        public string Degree { get; set; }
        public string Institution { get; set; }
        public string StillStudying { get; set; }
        public string Notes { get; set; }
        public string Thesis { get; set; }
        public DateTime? EntranceDate { get; set; }
        public DateTime? GraduationDate { get; set; }


        public Employee Employee { get; set; }
    }
}
