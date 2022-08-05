namespace MagazaSistemi.Models
{
    public class SatisDto
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string? PersonelAd { get; set; }
        public string? PersonelSoyad { get; set; }
        public int MagazaId { get; set; }
        public string? MagazaAd { get; set; }


        public int UrunId { get; set; }
        public string? UrunAd { get; set; }
        public decimal UrunFiyat { get; set; }
        public string? Belesmi { get; set; }

        public int MusteriId { get; set; }
        public string? MusteriAd { get; set; }
        public string? MusteriSoyad { get; set; }




    }
}
