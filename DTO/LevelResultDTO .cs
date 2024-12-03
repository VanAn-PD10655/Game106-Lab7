using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServerGame106.DTO
{

    public class LevelResultDTO
    {
        public required string UserId { get; set; }

        public required int LevelId { get; set; }

        public required int Score { get; set; }
    }
}