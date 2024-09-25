using HRManagementSystem.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.Queries
{
    public class GetAllDepartmentsQuery : IRequest<IEnumerable<DepartmentDto>>
    {
    }
}
