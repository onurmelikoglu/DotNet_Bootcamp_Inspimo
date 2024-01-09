using HasARelationship.Entities.Bases;

namespace HasARelationship.Entities
{
    public class Gezegen : GokCismiBase
    {
        public bool YasamVarMi { get; set; }

        public Yildiz Yildiz { get; set; }

        public List<Uydu> Uydular { get; set; }

        public Gezegen()
        {
            Uydular = new List<Uydu>();
        }
    }
}
