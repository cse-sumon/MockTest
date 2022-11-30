using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.Auth;

namespace Model
{
    public class MockTestContext : IdentityDbContext<ApplicationUser>
    {
        public MockTestContext(DbContextOptions<MockTestContext> options) : base(options)
        {
                
        }

        public DbSet<SubjectModel> Subjects { get; set; }
        public DbSet<StepModel> Steps { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<ExamModel> Exams { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}