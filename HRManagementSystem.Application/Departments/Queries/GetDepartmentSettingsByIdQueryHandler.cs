using HRManagementSystem.Application.Departments.DTOs;
using HRManagementSystem.Infrastructure.Departments.Interfaces;
using MediatR;

namespace HRManagementSystem.Application.Departments.Queries
{
    public class GetDepartmentSettingsByIdQueryHandler(IDepartmentSettingsRepository departmentSettingsRepository)
        : IRequestHandler<GetDepartmentSettingsByIdQuery, DepartmentSettingsDto>
    {
        public async Task<DepartmentSettingsDto> Handle(GetDepartmentSettingsByIdQuery request, CancellationToken cancellationToken)
        {
            var settings = await departmentSettingsRepository.GetByIdAsync(request.Id);
            var departmentSettingsDto = new DepartmentSettingsDto
            {
                Id = settings.Id,
                DepartmentId = settings.DepartmentId,
                RequiresApprovalForLeave = settings.RequiresApprovalForLeave
            };

            return departmentSettingsDto;
        }
    }
}
