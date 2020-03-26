using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASI_A2_Team5.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASI_A2_Team5.Controllers
{
    public class MessagesController
    {
        private IMessagesService _service;

        public MessagesController(IMessagesService service)
        {
            _service = service;
        }

        [HttpGet("/api/messages")]
        public ActionResult<List<Messages>> GetMessages()
        {
            return _service.GetMessages();
        }

        [HttpPost("/api/messages")]
        public ActionResult<Messages> AddMessages([FromBody]Messages message)
        {
            _service.AddMessages(message);
            return message;
        }

        [HttpPut("/api/messages/{id}")]
        public ActionResult<Messages> UpdateMessages(int id, [FromBody]Messages message)
        {
            _service.UpdateMessages(id, message);
            return message;
        }

        [HttpDelete("/api/messages/{id}")]
        public ActionResult<int> DeleteMessages(int id)
        {
            _service.DeleteMessages(id);
            return id;
        }

    }
}
