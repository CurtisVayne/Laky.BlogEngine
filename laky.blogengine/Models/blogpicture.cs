using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace Laky.Blogengine.Models
{
    public class blogpicture
    {
        [Dapper.Key]
        public int picture_id { get; set; }
        public DateTime created { get; set; }
        public string filename { get; set; }
        public string path { get; set; }
        public string tags { get; set; }
        public byte[] imagedata { get; set; }
    }
}
