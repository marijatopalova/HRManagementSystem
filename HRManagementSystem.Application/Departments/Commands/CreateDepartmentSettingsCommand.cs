using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.Departments.Commands
{
    public class CreateDepartmentSettingsCommand : IRequest<int>
    {
        public int DepartmentId { get; set; }
        public bool RequiresApprovalForLeave { get; set; }
    }
}
