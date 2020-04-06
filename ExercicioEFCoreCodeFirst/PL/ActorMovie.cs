using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class ActorMovie
    {
        public int ActorId { get; set; }
        public String Character { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
        public int ActorMovieId { get; set; }
    }
}
