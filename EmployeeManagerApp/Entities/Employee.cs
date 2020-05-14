namespace EmployeeManagerApp.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDeleted { get; private set; }

        public void Delete()
        {
            IsDeleted = true;
        }
        //pomijam Data utworzenia i przez kogo jak również ewentualne dane o modyfikacjach.
    }
}
