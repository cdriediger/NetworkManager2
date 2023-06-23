namespace NetworkManager2.Models
{
    public partial class Vlan
    {
        public int id { get; set; }
        public int vlanId { get; set; }
        public string name { get; set; }

        public Vlan(int vlanId, string name)
        {
            this.vlanId = vlanId;
            this.name = name;
        }

        public Vlan(int vlanId)
        {
            this.vlanId = vlanId;
        }

        public Vlan()
        {
        }
    }
}