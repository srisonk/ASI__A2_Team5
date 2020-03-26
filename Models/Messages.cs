using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASI_A2_Team5.Models
{
    public class Messages
    {
        public int Msg_id { get; set; }
        public int Id_sender { get; set; }
        public int Id_receiver { get; set; }
        public string Content { get; set; }
        public DateTime date { get; set; }
    }
}
