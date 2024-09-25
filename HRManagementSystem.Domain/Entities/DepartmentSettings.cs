using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Domain.Entities
{
    public class DepartmentSettings
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public bool RequiresApprovalForLeave { get; set; }
        public Department Department { get; set; }
    }
}
