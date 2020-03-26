using ASI_A2_Team5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASI_A2_Team5
{
    public interface IMenteesService
    {
        public List<Mentee> GetMentees();

        public Mentee AddMentee(Mentee mentee);

        public Mentee UpdateMentee(int id, Mentee mentee);

        public int DeleteMentee(int id);
    }
}
