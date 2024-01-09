

using HasARelationship.Entities.Bases;

namespace HasARelationship.Entities
{
    public class Yildiz : GokCismiBase
    {
        public float SicaklikC { get; set; }
        public float SicaklikF => SicaklikC * 1.8f + 32;

        public List<Gezegen> Gezegenler { get; set; } = new List<Gezegen>();
    }
}
