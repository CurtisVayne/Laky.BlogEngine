using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Laky.Blogengine.Models
{
    public class BlogEntry
    {
        [Dapper.Key]
        public int blogid { get; set; }
        public DateTime created { get; set; }
        [MaxLength(200)]
        public string title { get; set; }
        [MaxLength(200)]
        public string slug { get; set; }
        public string tags { get; set; }
        public string content { get; set; }
        public bool published { get; set; }
        public string lang { get; set; }
        [MaxLength(200)]
        public string metadescription { get; set; }
    }
}
