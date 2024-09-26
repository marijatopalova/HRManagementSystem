using HRManagementSystem.Domain.Departments;
using HRManagementSystem.Infrastructure.Departments.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.Departments.Commands
{
    public class CreateDepartmentSettingsCommandHandler(IDepartmentSettingsRepository departmentSettingsRepository) : IRequestHandler<CreateDepartmentSettingsCommand, int>
    {
        public async Task<int> Handle(CreateDepartmentSettingsCommand request, CancellationToken cancellationToken)
        {
            var settings = new DepartmentSettings
            {
                DepartmentId = request.DepartmentId,
                RequiresApprovalForLeave = request.RequiresApprovalForLeave
            };

            await departmentSettingsRepository.AddAsync(settings);
            return settings.Id;
        }
    }
}
