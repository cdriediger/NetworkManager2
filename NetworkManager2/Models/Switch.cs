using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetworkManager2.Adapters;
using NetworkManager2.Models;

namespace NetworkManager2.Models
{
    public partial class Switch
    {
        //static data
        public int id { get; set; }
        public string ipv4 { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int model { get; set; }
        public virtual ICollection<Port> ports { get; set; }

        //dymamic updated data
        public string name { get; set; }
        public string location { get; set; }
        public string modelName {get; set;}
        public DateTime lastUpdate {get; set;}
        
        [NotMapped]
        public ISwitchAdapter adapter {get; set;}

        public Switch()
        {
            ports = new List<Port>();
        }
    }
}
