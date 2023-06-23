using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetworkManager2.Models
{
    public partial class Profile
    {
        public int id { get; set; }
        public string name { get; set; }

        public int nativeVlan { get; set; }
        public virtual TaggedVlans taggedVlans { get; set; }

        [NotMapped]
        public List<int> TaggedVLanIds {get; set;}

        //relation data
        //public int portId { get; set; }
        //public virtual Ports port { get; set; }
    }
}