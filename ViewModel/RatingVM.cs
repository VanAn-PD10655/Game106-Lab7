using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServerGame106.ViewModel
{

    public class RatingVM
    {
        public string NameRegion { get; set; }

        public List<UserResultSum> userResultSums { get; set; }
    }
    public class UserResultSum
    {
        public string NameUser { get; set; }

        public int SumScore { get; set; }

        public int SumLevel { get; set; }
    }
}