using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServerGame106.DTO
{

    public class UserInformationDTO
    {
        public string UserId { get; set; }

        public string Name { get; set; }

        public int RegionId { get; set; }

        public IFormFile Avatar { get; set; }
    }
}