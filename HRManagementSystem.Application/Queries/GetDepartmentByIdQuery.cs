using HRManagementSystem.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.Queries
{
    public class GetDepartmentByIdQuery : IRequest<DepartmentDto>
    {
        public int Id { get; set; }
    }
}
