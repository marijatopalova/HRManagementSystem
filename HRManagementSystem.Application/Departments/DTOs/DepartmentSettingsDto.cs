using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.Departments.DTOs
{
    public class DepartmentSettingsDto
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public bool RequiresApprovalForLeave { get; set; }
    }
}
