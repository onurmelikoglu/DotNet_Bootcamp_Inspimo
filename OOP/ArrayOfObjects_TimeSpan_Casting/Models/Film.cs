using ArrayOfObjects_TimeSpan_Casting.Models.Bases;

namespace ArrayOfObjects_TimeSpan_Casting.Models
{
    public class Film : Video
    {
        public string Yonetmen { get; set; }
        public string[] Oyuncular { get; set; }
        public float ImdbPuani { get; set; }
    }
}
