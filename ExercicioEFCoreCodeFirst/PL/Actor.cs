using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class Actor
    {
        public int ActorId { get; set; }
        public DateTime DateBirth { get; set; }
        public String Name { get; set; }
        public ICollection<ActorMovie> Characters { get; set; }
    }
}
