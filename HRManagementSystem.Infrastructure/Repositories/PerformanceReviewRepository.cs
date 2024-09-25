using HRManagementSystem.Domain.Entities;
using HRManagementSystem.Infrastructure.Data;
using HRManagementSystem.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Infrastructure.Repositories
{
    public class PerformanceReviewRepository(ApplicationDbContext dbContext) : IPerformanceReviewRepository
    {
        public async Task<PerformanceReview> GetByIdAsync(int id)
        {
            return await dbContext.PerformanceReviews
                .Include(e => e.Employee)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<PerformanceReview>> GetAllAsync()
        {
            return await dbContext.PerformanceReviews
                .Include(e => e.Employee)
                .ToListAsync();
        }

        public async Task AddAsync(PerformanceReview review)
        {
            await dbContext.PerformanceReviews.AddAsync(review);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(PerformanceReview review)
        {
            dbContext.PerformanceReviews.Update(review);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var review = await GetByIdAsync(id);
            if (review != null)
            {
                dbContext.PerformanceReviews.Remove(review);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
