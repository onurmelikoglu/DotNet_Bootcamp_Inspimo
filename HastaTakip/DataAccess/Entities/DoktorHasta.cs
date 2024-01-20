#nullable disable
using DataAccess.Records.Bases;

namespace DataAccess.Entities
{
    //1. yöntem 
    //[PrimaryKey(nameof(DoktorId), nameof(HastaId)]
    //public class DoktorHasta
    //{
    //    [Key]
    //    public int DoktorId { get; set; } // foreign key
    //    public Doktor Doktor { get; set; }
    //    [Key]
    //    public int HastaId { get; set; } // foreign key
    //    public Hasta Hasta { get; set; }
    //}

    //2. yöntem
    public class  DoktorHasta : Record
    {
        public int DoktorId { get; set; } // foreing key, veritabanı many to many ilişki
        public Doktor Doktor { get; set; } // many to many has a relationship ilişki

        public int HastaId { get; set; } // foreing key, veritabanı many to many ilişki
        public Hasta Hasta { get; set; } // many to many has a relationship ilişki
    }
}
