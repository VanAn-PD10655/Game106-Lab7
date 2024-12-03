using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerGame106.Models
{
    public class LevelResult
    {
        [Key]
        public int QuizResultId { get; set; }
        [ForeignKey("User")]

        public string UserId { get; set; }

        [ForeignKey("Level")]

        public int LevelId { get; set; }

        public int Score { get; set; }

        public DateOnly CompletionDate { get; set; }
    }
}