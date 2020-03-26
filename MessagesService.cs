using ASI_A2_Team5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASI_A2_Team5
{
    public class MessagesService : IMessagesService
    {
        private List<Messages> _messages;

        public MessagesService()
        {
            _messages = new List<Messages>();
        }

        public List<Messages> GetMessages()
        {
            return _messages;
        }

        public Messages AddMessages(Messages message)
        {
            _messages.Add(message);
            return message;
        }

        public Messages UpdateMessages(int id, Messages message)
        {
            for (var index = _messages.Count - 1; index >= 0; index--)
            {
                if (_messages[index].Msg_id == id)
                {
                    _messages[index] = message;
                }
            }

            return message;
        }

        public int DeleteMessages(int id)
        {
            for (var index = _messages.Count - 1; index >= 0; index--)
            {
                if (_messages[index].Msg_id == id)
                {
                    _messages.RemoveAt(index);
                }
            }

            return id;
        }
    }
}
