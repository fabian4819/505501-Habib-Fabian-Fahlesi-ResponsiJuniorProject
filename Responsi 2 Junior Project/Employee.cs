using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_2_Junior_Project
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int DepartmentId { get; set; }
        public string ManagerId { get; set; }

        public Employee(string name, string department, int departmentId, string managerId = null)
        {
            Name = name;
            Department = department;
            DepartmentId = departmentId;
            ManagerId = managerId;
        }
    }
}
