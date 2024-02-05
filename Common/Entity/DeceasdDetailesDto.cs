using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entity
{
    
    public class DeceasdDetailesDto
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public DateTime Birth_date { get; set; }
        public DateTime Death_date { get; set; }
        public string Hometown { get; set; }
        public string Burial_location { get; set; }
        public int Age { get; set; }
        public virtual ICollection<UserDetailes> users { get; set; }
        public virtual ICollection<string> images { get; set; }
        public string Death_detailes { get; set; }
        public string Rank { get; set; }
        public virtual ICollection<StoryDetailes> Stories { get; set; }
    }
}
