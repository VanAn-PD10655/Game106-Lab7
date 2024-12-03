using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServerGame106.Models
{
    public class ResponseApi
    {
        public bool IsSuccess { get; set; }
        public string Notification { get; set; }
        public object Data { get; set; }
    }
}