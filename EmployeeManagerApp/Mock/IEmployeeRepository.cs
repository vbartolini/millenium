using EmployeeManagerApp.Entities;
using System.Collections.Generic;

namespace EmployeeManagerApp.Mock
{
    public interface IEmployeeRepository
    {
        List<Employee> EmployeeList { get; }
        void Create(Employee employee);
        Employee Get(int employeeId);
        void Update(Employee employee);
        void Delete(int employeeId);
    }
}
