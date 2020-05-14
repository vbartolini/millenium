using System.Collections.Generic;

namespace EmployeeManagerApp.Models
{
    public class EmployeeListModel
    {
        public List<EmployeeListItemModel> List;

        public EmployeeListModel()
        {
            List = new List<EmployeeListItemModel>();
        }
    }

    public class EmployeeListItemModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
