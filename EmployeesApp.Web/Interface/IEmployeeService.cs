﻿using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Interface
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        Employee[] GetAll();
        Employee GetById(int id);
        bool CheckIsVIP (Employee employee);
    }
}




