using ASI_A2_Team5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASI_A2_Team5
{
    public class MenteesService : IMenteesService
    {
        private List<Mentee> _mentees;

        public MenteesService()
        {
            _mentees = new List<Mentee>();
        }

        public List<Mentee> GetMentees()
        {
            return _mentees;
        }

        public Mentee AddMentee(Mentee mentee)
        {
            _mentees.Add(mentee);
            return mentee;
        }

        public Mentee UpdateMentee(int id, Mentee mentee)
        {
            for (var index = _mentees.Count - 1; index >= 0; index--)
            {
                if (_mentees[index].Id == id)
                {
                    _mentees[index] = mentee;
                }
            }

            return mentee;
        }

        public int DeleteMentee(int id)
        {
            for (var index = _mentees.Count - 1; index >= 0; index--)
            {
                if (_mentees[index].Id == id)
                {
                    _mentees.RemoveAt(index);
                }
            }

            return id;
        }
    }
}
