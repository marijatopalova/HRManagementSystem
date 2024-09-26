using HRManagementSystem.Application.Departments.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.Departments.Queries
{
    public class GetDepartmentSettingsByIdQuery : IRequest<DepartmentSettingsDto>
    {
        public int Id { get; set; }
    }
}
