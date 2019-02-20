using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboration3.Models
{
    public class ViewModelConnectActorMovie
    {
        public IEnumerable<MovieDetail> MovieList { get; set; }
        public IEnumerable<ActorDetail> ActorList { get; set; }
    }

}
