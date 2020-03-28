using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD
{
    public class PageContent
    {
        public String ID { get; set; }
        public int Id_user { get; set; }
        public int Text { get; set; }
        public String Type { get; set; }
        public DateTime Date { get; set; }
        public int Is_deleted { get; set; }
    }

}