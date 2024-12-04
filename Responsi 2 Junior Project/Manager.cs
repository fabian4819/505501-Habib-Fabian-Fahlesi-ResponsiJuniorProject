using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_2_Junior_Project
{
    public class Manager : Employee
    {
        private readonly List<Employee> _managedEmployees;

        public Manager(string name, string department, int departmentId)
            : base(name, department, departmentId)
        {
            _managedEmployees = new List<Employee>();
        }

        public void AddEmployee(Employee employee) => _managedEmployees.Add(employee);
        public void RemoveEmployee(Employee employee) => _managedEmployees.Remove(employee);
        public IReadOnlyList<Employee> GetManagedEmployees() => _managedEmployees.AsReadOnly();
    }
}
