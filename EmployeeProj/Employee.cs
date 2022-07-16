using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProj
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string AddressLine { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public string KPI { get; set; }
        public int AddressId { get; set; }
        public int PositionId { get; set; }
        public int KPIId { get; set; }
    }
}
