using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EmpLanguage
    {
        public int EmployeeId { get; set; }
        public string Language { get; set; }
        public Level? WrittenLevel { get; set; }
        public Level? SpeakingLevel { get; set; }
        public string NativeLang { get; set; }

        public int LanguageId { get; set; }
        public string Notes { get; set; }

        public Employee Employee { get; set; }
    }
}
