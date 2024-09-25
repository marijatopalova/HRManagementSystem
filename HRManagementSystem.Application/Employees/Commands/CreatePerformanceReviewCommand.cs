using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.Employees.Commands
{
    public class CreatePerformanceReviewCommand : IRequest<int>
    {
        public int EmployeeId { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Feedback { get; set; }
        public int Rating { get; set; }
    }
}
