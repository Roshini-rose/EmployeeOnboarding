﻿using EmployeeOnboarding.Data;
using EmployeeOnboarding.Models;
//using EmployeeOnboarding.Models;

namespace EmployeeOnboarding.Contracts
{
    public interface IAdminRepository
    {
      Task <List<DashboardVM>> GetEmployeeDetails();
      Task DeleteEmployee(string[] employeeId);   
        
        Task <List<PersonalInfoVM>>? GetPersonalInfo(string employeeid);
       
    }
}