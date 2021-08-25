using Application.AppService;
using Application.Common;
using Application.Common.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.AppServices
{
    public class EmployeeServices : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly HRMContext _context;
        public EmployeeServices(HRMContext context) : base(context)
        {
            _context = context;
        }

        public EmpAttachment AddEmpAttachment(EmpAttachment attachment)
        {
            _context.EmpAttachments.Add(attachment);
            _context.SaveChanges();
            return attachment;
        }



        public EmpCertificate AddEmpCertificate(EmpCertificate certificate)
        {
            _context.EmpCertificates.Add(certificate);
            _context.SaveChanges();
            return certificate;
        }

        public EmpEducation AddEmpEducation(EmpEducation education)
        {
            _context.EmpEducations.Add(education);
            _context.SaveChanges();
            return education;
        }

        public EmpLanguage AddEmpLanguages(EmpLanguage language)
        {
            _context.EmpLanguages.Add(language);
            _context.SaveChanges();
            return language;
        }

        public EmpProject AddEmpProject(EmpProject project)
        {
            _context.EmpProjects.Add(project);
            _context.SaveChanges();
            return project;
        }

        public EmpEmergCall AddEmployeeEmergencyCall(EmpEmergCall emergency_Call)
        {
            _context.EmpEmergCalls.Add(emergency_Call);
            _context.SaveChanges();
            return emergency_Call;
        }

        public EmpTechSkill AddEmpTechSkill(EmpTechSkill technicalSkill)
        {
            _context.EmpTechSkills.Add(technicalSkill);
            _context.SaveChanges();
            return technicalSkill;

        }

        public EmpTraining AddEmpTraining(EmpTraining training)
        {
            _context.EmpTrainings.Add(training);
            _context.SaveChanges();
            return training;
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }

        /
        public Employee UpdateEmployee(Employee employeeEdit)
        {
            var employ = _context.Employees.FirstOrDefault(e => e.EmployeeId == employeeEdit.EmployeeId);

            if (employ != null)
            {
                employ.EmployeeId = employeeEdit.EmployeeId;
                
                employ.Firstname = employeeEdit.Firstname;
                employ.Lastname = employeeEdit.Lastname;
                employ.Phone = employeeEdit.Phone;
                employ.Email = employeeEdit.Email;
                employ.HomeAddress = employeeEdit.HomeAddress;
                employ.Department = employeeEdit.Department;
                employ.City = employeeEdit.City;
                employ.Country = employeeEdit.Country;
                employ.JobTitle = employeeEdit.JobTitle;
                employ.Rank = employeeEdit.Rank;
                employ.BloodType = employeeEdit.BloodType;
                employ.MaritalStatus = employeeEdit.MaritalStatus;
                employ.DateOfBirth = employeeEdit.DateOfBirth;
                employ.Gender = employeeEdit.Gender;
                employ.PhotoPath = employeeEdit.PhotoPath;
                employ.Nationality = employeeEdit.Nationality;
                employ.HomePhone = employeeEdit.HomePhone;
                employ.JobLocation = employeeEdit.JobLocation;
                employ.IsConfirmed = employeeEdit.IsConfirmed;
                employ.CreatedBy = employeeEdit.CreatedBy;
                employ.CreateDate = employeeEdit.CreateDate;
                employ.LastModifiedBy = employeeEdit.LastModifiedBy;
                employ.StartDate = employeeEdit.StartDate;
                employ.QuitDate = employeeEdit.QuitDate;
                employ.IsLeavedJob = employeeEdit.IsLeavedJob;
                employ.LeaveJobDate = employeeEdit.LeaveJobDate;
                employ.LeaveJobReason = employeeEdit.LeaveJobReason;
                employ.LegalDayOff = employeeEdit.LegalDayOff;

            }
            _context.SaveChanges();
            return employ;
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _context.Employees;
        }
        public IEnumerable<Employee> SearchAllEmployee(string searchString)
        {

            return _context.Employees.Where(e =>
                   e.Firstname.ToLower().Contains(searchString)
                 || e.Lastname.ToLower().Contains(searchString)
                 || e.JobTitle.ToLower().Contains(searchString)
                 || e.Email.ToLower().Contains(searchString)
           || e.Phone.Contains(searchString));
        }

        // Hr Service start here
        public Employee HrAddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee HrDeleteEmployee(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeId == id);

            if (employee != null)
            {
                _context.Remove(employee);
            }
            _context.SaveChanges();
            return employee;

        }

        public IEnumerable<Employee> HrGetAllEmployee()
        {
            return _context.Employees;
        }
        public IEnumerable<Employee> HrSearchAllEmployee(string searchString)
        {
            return _context.Employees.Where(e =>
                  e.Firstname.ToLower().Contains(searchString)
                || e.Lastname.ToLower().Contains(searchString)
                || e.JobTitle.ToLower().Contains(searchString)
                || e.Email.ToLower().Contains(searchString)
          || e.Phone.Contains(searchString));
        }

        public Employee HrGetEmployee(int id, string name)
        {
            return _context.Employees.FirstOrDefault(e => e.EmployeeId == id

            || e.Firstname == name);
        }

        

        public Employee HrUpdateEmployeeData(Employee employeeChange)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeId == employeeChange.EmployeeId);

            if (employee != null)
            {
                employee.EmployeeId = employeeChange.EmployeeId;
               
                employee.Firstname = employeeChange.Firstname;
                employee.Lastname = employeeChange.Lastname;
                employee.Phone = employeeChange.Phone;
                employee.Email = employeeChange.Email;
                employee.HomeAddress = employeeChange.HomeAddress;
                employee.Department = employeeChange.Department;
                employee.City = employeeChange.City;
                employee.Country = employeeChange.Country;
                employee.JobTitle = employeeChange.JobTitle;
                employee.Rank = employeeChange.Rank;
                employee.BloodType = employeeChange.BloodType;
                employee.MaritalStatus = employeeChange.MaritalStatus;
                employee.DateOfBirth = employeeChange.DateOfBirth;
                employee.Gender = employeeChange.Gender;
                employee.PhotoPath = employeeChange.PhotoPath;
                employee.Nationality = employeeChange.Nationality;
                employee.HomePhone = employeeChange.HomePhone;
                employee.JobLocation = employeeChange.JobLocation;
                employee.IsConfirmed = employeeChange.IsConfirmed;
                employee.CreatedBy = employeeChange.CreatedBy;
                employee.CreateDate = employeeChange.CreateDate;
                employee.LastModifiedBy = employeeChange.LastModifiedBy;
                employee.StartDate = employeeChange.StartDate;
                employee.QuitDate = employeeChange.QuitDate;
                employee.IsLeavedJob = employeeChange.IsLeavedJob;
                employee.LeaveJobDate = employeeChange.LeaveJobDate;
                employee.LeaveJobReason = employeeChange.LeaveJobReason;
                employee.LegalDayOff = employeeChange.LegalDayOff;
            }
            _context.SaveChanges();
            return employee;
        }

        // Manager Service Start Here

        public IEnumerable<Employee> MaGetAllEmployee()
        {
            return _context.Employees;
        }
        public Employee MaGetEmployee(int id, string name)
        {
            return _context.Employees.FirstOrDefault(e => e.EmployeeId == id

            || e.Firstname == name || e.Lastname == name || e.Email == name || e.JobTitle == name);
        }

        public IQueryable<Employee> MaQueryAllEmployee(string searchString)
        {
            return _context.Employees.Where(e =>
                  e.Firstname.ToLower().Contains(searchString)
                || e.Lastname.ToLower().Contains(searchString)
                || e.JobTitle.ToLower().Contains(searchString)
                || e.Email.ToLower().Contains(searchString)
          || e.Phone.Contains(searchString));
        }



        public Employee MaUpdateEmployeeData(Employee employeeChange)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeId == employeeChange.EmployeeId);

            if (employee != null)
            {
                employee.EmployeeId = employeeChange.EmployeeId;
                
                employee.Firstname = employeeChange.Firstname;
                employee.Lastname = employeeChange.Lastname;
                employee.Phone = employeeChange.Phone;
                employee.Email = employeeChange.Email;
                employee.HomeAddress = employeeChange.HomeAddress;
                employee.Department = employeeChange.Department;
                employee.City = employeeChange.City;
                employee.Country = employeeChange.Country;
                employee.JobTitle = employeeChange.JobTitle;
                employee.Rank = employeeChange.Rank;
                employee.BloodType = employeeChange.BloodType;
                employee.MaritalStatus = employeeChange.MaritalStatus;
                employee.DateOfBirth = employeeChange.DateOfBirth;
                employee.Gender = employeeChange.Gender;
                employee.PhotoPath = employeeChange.PhotoPath;
                employee.Nationality = employeeChange.Nationality;
                employee.HomePhone = employeeChange.HomePhone;
                employee.JobLocation = employeeChange.JobLocation;
                employee.IsConfirmed = employeeChange.IsConfirmed;
                employee.CreatedBy = employeeChange.CreatedBy;
                employee.CreateDate = employeeChange.CreateDate;
                employee.LastModifiedBy = employeeChange.LastModifiedBy;
                employee.StartDate = employeeChange.StartDate;
                employee.QuitDate = employeeChange.QuitDate;
                employee.IsLeavedJob = employeeChange.IsLeavedJob;
                employee.LeaveJobDate = employeeChange.LeaveJobDate;
                employee.LeaveJobReason = employeeChange.LeaveJobReason;
                employee.LegalDayOff = employeeChange.LegalDayOff;

            }
            _context.SaveChanges();
            return employee;
        }

        public class EmployeeDal
        {
            private readonly HRMContext _context;

            public EmployeeDal(HRMContext context)
            {
                _context = context;
            }
            public Page<Employee> GetEmployeeReport(int pageSize, int currentPage, string searchText, int sortBy, string jobPosition, string empDepartment)
            {
                Page<Employee> employees;
                var filters = new Filters<Employee>();
                filters.Add(!string.IsNullOrEmpty(searchText), x => x.Firstname.Contains(searchText));
                filters.Add(!string.IsNullOrEmpty(jobPosition), x => x.JobTitle.Equals(jobPosition));
                filters.Add(!string.IsNullOrEmpty(empDepartment), x => x.Department.Equals(empDepartment));

                var sorts = new Sorts<Employee>();

                

                sorts.Add(sortBy == 3, x => x.JobTitle, false, 1);
                sorts.Add(sortBy == 1, x => x.Department, true, 2);
                sorts.Add(true, x => x.Firstname, true, 3);



                employees = _context.Employees.Paginate(currentPage, pageSize, sorts, filters);


                return employees;
            }
        }
    }
}
    
}
