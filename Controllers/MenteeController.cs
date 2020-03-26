using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASI_A2_Team5.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASI_A2_Team5.Controllers
{
    public class MenteeController
    {
        private IMenteesService _service;

        public MenteeController(IMenteesService service)
        {
            _service = service;
        }

        [HttpGet("/api/mentees")]
        public ActionResult<List<Mentee>> GetMentees()
        {
            return _service.GetMentees();
        }

        [HttpPost("/api/mentees")]
        public ActionResult<Mentee> AddMentee([FromBody]Mentee mentee)
        {
            _service.AddMentee(mentee);
            return mentee;
        }

        [HttpPut("/api/mentees/{id}")]
        public ActionResult<Mentee> UpdateMentee(int id, [FromBody]Mentee mentee)
        {
            _service.UpdateMentee(id, mentee);
            return mentee;
        }

        [HttpDelete("/api/mentees/{id}")]
        public ActionResult<int> DeleteMentee(int id)
        {
            _service.DeleteMentee(id);
            return id;
        }

    }
}
