using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManagementSystem.Domain.Employees;

namespace HRManagementSystem.Domain.PayrollManagement
{
    public class Payroll
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public Employee Employee { get; set; }
    }
}
