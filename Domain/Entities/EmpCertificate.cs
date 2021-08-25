using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EmpCertificate
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public string Provider { get; set; }
        public DateTime? Date { get; set; }
        public string Notes { get; set; }

        public Employee Employee { get; set; }

    }
}
