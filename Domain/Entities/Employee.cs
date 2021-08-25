using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee
    {
        public Employee()
        {
            EmpAttachments = new HashSet<EmpAttachment>();
            EmpCertificates = new HashSet<EmpCertificate>();
            EmpEducations = new HashSet<EmpEducation>();
            EmpLanguages = new HashSet<EmpLanguage>();
            EmpTechSkills = new HashSet<EmpTechSkill>();
            EmpProjects = new HashSet<EmpProject>();
            EmpTrainings = new HashSet<EmpTraining>();
        }


        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public Dept? Department { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string JobTitle { get; set; }
        public string Rank { get; set; }
        public string BloodType { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhotoPath { get; set; }
        public string Nationality { get; set; }
        public string HomePhone { get; set; }
        public string JobLocation { get; set; }
        public bool IsConfirmed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? QuitDate { get; set; }
        public bool IsLeavedJob { get; set; }
        public DateTime? LeaveJobDate { get; set; }
        public string LeaveJobReason { get; set; }

        public string LegalDayOff { get; set; }
        public EmpQuit EmpQuit { get; set; }
        public ICollection<EmpAttachment> EmpAttachments { get; set; }
        public ICollection<EmpLanguage> EmpLanguages { get; set; }
        public ICollection<EmpProject> EmpProjects { get; set; }
        public ICollection<EmpTechSkill> EmpTechSkills { get; set; }
        public ICollection<EmpCertificate> EmpCertificates { get; set; }
        public ICollection<EmpEducation> EmpEducations { get; set; }
        public ICollection<EmpEmergCall> EmpEmergCalls { get; set; }
        public ICollection<EmpTraining> EmpTrainings { get; set; }

    }
}
