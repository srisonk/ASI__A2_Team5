using ASI_A2_Team5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASI_A2_Team5
{
    public interface IMessagesService
    {
        public List<Messages> GetMessages();

        public Messages AddMessages(Messages message);

        public Messages UpdateMessages(int id, Messages message);

        public int DeleteMessages(int id);
    }
}