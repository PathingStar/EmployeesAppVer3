using EmployeesApp.Web.Interface;
using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public class OtherEmployeeService : IEmployeeService

    {
        readonly List<Employee> employees =
        [
            new Employee()
            {
                Id = 562,
                Name = "Ben Dover",
                Email = "Admin.Dover@outlook.com",
            },
            new Employee()
            {
                Id = 62,
                Name = "Mike Hunt",
                Email = "mh@outlook.com",
            },
            new Employee()
            {
                Id = 15662,
                Name = "Eileen Dover",
                Email = "dover@outlook.com",
            },
            new Employee()
            {
                Id = 52,
                Name = "Mike Hawk",
                Email = "m.h@outlook.com",
            },
            new Employee()
            {
                Id = 563,
                Name = "Harry Bawls",
                Email = "h.b@outlook.com",
            },
        ];

        public void Add(Employee employee)
        {
            employee.Id = employees.Count < 0 ? 1 : employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }
        public Employee GetById(int id) => employees
            .Single(e => e.Id == id);

        public bool CheckIsVIP(Employee employee) =>
            employee.Email.StartsWith("ADMIN", StringComparison.CurrentCultureIgnoreCase);

        public Employee[] GetAll() => [.. employees.OrderBy(e => e.Name)];
    }

}
