using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee UpdateEmployee(Employee employee);
        IEnumerable<Employee> SearchAllEmployee(string searchString);
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployee(int id);
        EmpProject AddEmpProject(EmpProject project);

        EmpTechSkill AddEmpTechSkill(EmpTechSkill technicalSkill);

        EmpEducation AddEmpEducation(EmpEducation education);

        EmpLanguage AddEmpLanguages(EmpLanguage language);

        EmpTraining AddEmpTraining(EmpTraining training);

        EmpCertificate AddEmpCertificate(EmpCertificate certificate);

        EmpEmergCall AddEmployeeEmergencyCall(EmpEmergCall emergency_Call);

        EmpAttachment AddEmpAttachment(EmpAttachment attachment);


        // Repository for Manager

        Employee MaGetEmployee(int id, string name);
        IEnumerable<Employee> MaGetAllEmployee();
        IQueryable<Employee> MaQueryAllEmployee(string searchString);

        Employee MaUpdateEmployeeData(Employee employeeChange);

        // Repository for HR
        Employee HrGetEmployee(int id, string name);
        // Employee GetEmployeeByName(string name);
        IEnumerable<Employee> HrSearchAllEmployee(string searchString);
        IEnumerable<Employee> HrGetAllEmployee();
        Employee HrAddEmployee(Employee employee);
        Employee HrUpdateEmployeeData(Employee employeeChange);
        // Employee GetEmployeeReport(int pageSize, int currentPage, string searchText, int sortBy, string jobPosition, string empDepartment);


        Employee HrDeleteEmployee(int id);
    }
}
