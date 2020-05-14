using EmployeeManagerApp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagerApp.Mock
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> EmployeeList { get; private set; }

        public EmployeeRepository()
        {
            Init();
        }

        private void Init()
        {
            EmployeeList = new List<Employee> {
                new Employee() { Id = 1, FirstName = "Robert", LastName = "Lewandowski" },
                new Employee() { Id = 2, FirstName = "Łukasz", LastName = "Piszczek" },
                new Employee() { Id = 3, FirstName = "Wojciech", LastName = "Szczęsny" },
                new Employee() { Id = 4, FirstName = "Artur", LastName = "Borus" },
                new Employee() { Id = 5, FirstName = "Arkadiusz", LastName = "Milik" }
            };
        }

        public void Create(Employee employee)
        {
            //ewentualne sprawdzenie czy występuje pracownik z takim Id, Imieniem, Nazwiskiem, co kto chce.
            EmployeeList.Add(employee);
        }

        public Employee Get(int employeeId)
        {
            var e = EmployeeList.SingleOrDefault(x => x.Id == employeeId);
            if(e != null)
            {
                return e;
            }
            return null;
        }

        public void Update(Employee employee)
        {
            var e = EmployeeList.SingleOrDefault(x => x.Id == employee.Id);
            if (e != null)
            {
                e = employee;
            }
        }

        public void Delete(int employeeId)
        {
            var e = EmployeeList.SingleOrDefault(x => x.Id == employeeId);
            if(e != null)
            {
                e.Delete();
            }
        }
    }
}
