using ServerGame106.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace ServerGame106.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<GameLevel> GameLevels { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }



        public DbSet<LevelResult> LevelResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GameLevel>().HasData(
                new GameLevel { LevelId = 1, title = "Cấp độ 1" },
                new GameLevel { LevelId = 2, title = "Cấp độ 2" },
                new GameLevel { LevelId = 3, title = "Cấp độ 3" }
            );

            modelBuilder.Entity<Region>().HasData(
                new Region { RegionId = 1, Name = "Đồng bằng sông hồng" },
                new Region { RegionId = 2, Name = "Đồng bằng sông cuu long" }
             );
            modelBuilder.Entity<Question>().HasData(
            new Question
            {
                QuestionId = 1,
                ContentQuestion = "Câu hỏi 1",
                Answer = "Đáp án 1",
                Option1 = "Đáp án 1",
                Option2 = "Đáp án 2",
                Option3 = "Đáp án 3",
                Option4 = "Đáp án 4",
                levelId = 1
            },
            new Question
            {
                QuestionId = 2,
                ContentQuestion = "Câu hỏi 2",
                Answer = "Đáp án 2",
                Option1 = "Đáp án 1",
                Option2 = "Đáp án 2",
                Option3 = "Đáp án 3",
                Option4 = "Đáp án 4",
                levelId = 2
            }
            );
        }
    }
}