using EmployeeManagerApp.Mock;
using Xunit;
using System.Linq;

namespace EmployeeManagerAppTest
{
    public class EmployeeTest
    {
        [Fact]
        public void Is_Employee_Deleted()
        {
            var repo = new EmployeeRepository();
            var employee = repo.EmployeeList.SingleOrDefault(x => x.IsDeleted == false);
            employee.Delete();
            Assert.True(employee.IsDeleted);
        }
    }
}
