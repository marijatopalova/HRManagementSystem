using HRManagementSystem.Domain.Entities;
using HRManagementSystem.Infrastructure.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.Commands
{
    public class CreatePerformanceReviewCommandHandler(IPerformanceReviewRepository performanceReviewRepository) : IRequestHandler<CreatePerformanceReviewCommand, int>
    {
        public async Task<int> Handle(CreatePerformanceReviewCommand request, CancellationToken cancellationToken)
        {
            var review = new PerformanceReview
            {
                EmployeeId = request.EmployeeId,
                Feedback = request.Feedback,
                Rating = request.Rating,
                ReviewDate = request.ReviewDate,
            };

            await performanceReviewRepository.AddAsync(review);
            return review.Id;
        }
    }
}
