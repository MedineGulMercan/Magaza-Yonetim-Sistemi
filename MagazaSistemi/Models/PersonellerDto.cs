namespace MagazaSistemi.Models
{
    public class PersonellerDto
    {
        public int Id { get; set; }
        public string? PersonelAd { get; set; }
        public string? PersonelSoyad { get; set; }
        public int MagazaId { get; set; }

        public string? MagazaAd { get; set; }


    }
}
