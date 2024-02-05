using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Stories
    {
        public string Nickname { get; set; }
        public string Relation_type { get; set; }
        public string Story { get; set; }
        public string Email_for_messages { get; set; }
        public int Likes_number { get; set; }
        public int Reported_number { get; set; }
        public virtual ICollection<Responses> responses { get; set; }
    } 
}
