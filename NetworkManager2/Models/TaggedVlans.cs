using System.Collections.Generic;

namespace NetworkManager2.Models
{
    public partial class TaggedVlan
    {
        public int id { get; set; }
        public int vlanId { get; set; }

        //relation data
        public int? portId { get; set; }
        public virtual Port port { get; set; }

        public int? profileId { get; set; }
        public virtual Profile profile { get; set; }

        public TaggedVlan(int vlanId)
        {
            this.vlanId = vlanId;
        }
    }

    public partial class TaggedVlans : ICollection<TaggedVlan>
    {   

        ICollection<TaggedVlan> _items;


        public TaggedVlans() {
            // Default to using a List<T>.
            _items = new List<TaggedVlan>();
        }

        protected TaggedVlans(ICollection<TaggedVlan> collection) {
            // Let derived classes specify the exact type of ICollection<T> to wrap.
            _items = collection;
        }

        public void Add(TaggedVlan item) { 
            _items.Add(item); 
        }

        public void Clear() { 
            _items.Clear(); 
        }

        public bool Contains(TaggedVlan item) { 
            foreach (TaggedVlan vlan in _items)
            {
                if (vlan.vlanId == item.vlanId)
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(TaggedVlan[] array, int arrayIndex) { 
            _items.CopyTo(array, arrayIndex); 
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(TaggedVlan item)
        {
            return _items.Remove(item);
        }

        public IEnumerator<TaggedVlan> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}