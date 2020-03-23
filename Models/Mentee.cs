using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASI_A2_Team5.Models
{
    public class Mentee
    {
        public int Id {get; set; }
        public int UserId { get; set; }
        public int MentorId { get; set; }
        public string Qualification { get; set; }
        public string Class { get; set; }
    }
}
