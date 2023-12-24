namespace InterfaceVsAbstractClass.Bases
{
    public interface IOgrenciDosya
    {
        // E:\Development\GitRepo\DotNet_Bootcamp_Inspimo\OOP\InterfaceVsAbstractClass\Dosyalar

        string DosyaYolu { get; set; }

        string OgrencileriGetir(bool sayiEkle); // okuma

        void OgrenciEkle(string ogrenci); // yazma

        string DosyaAdiGetir();

        string DosyaUzantisiGetir();
    }
}
