using HasARelationship.Entities.Bases;

namespace HasARelationship.Entities
{
    public class Uydu : GokCismiBase
    {
        public Gezegen Gezegen { get; set; }
    }
}
