using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboration3.Models
{
    public class ViewModelAM
    {
        public IEnumerable<ActorMovie> ActorMovieList { get; set; }
        public IEnumerable<ActorDetail> ActorList { get; set; }
    }
}
