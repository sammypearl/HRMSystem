using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EmpAttachment
    {
        public string FileName { get; set; }

        public int EmployeeId { get; set; }
        public int? FileId { get; set; }
        public string URLOnly { get; set; }
        public string Notes { get; set; }
        public int FileSize { get; set; }
        public FileType Type { get; set; }


        public Employee Employee { get; set; }
    }
}
