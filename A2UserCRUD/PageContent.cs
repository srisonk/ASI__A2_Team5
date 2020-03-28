using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD
{
    public class PageContent
    {
        public int ID { get; set; }
        public int Id_user { get; set; }
        public String Text { get; set; }
        public int Type { get; set; }
        public DateTime Date { get; set; }
        public int Is_deleted { get; set; }
    }

}