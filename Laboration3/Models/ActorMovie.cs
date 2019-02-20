using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboration3.Models
{
    public class ActorMovie
    {
        public ActorMovie() { }

        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Movie { get; set; }
        public int ActorId { get; set; }
    }
}
