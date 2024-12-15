using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace formpage.Models
{
    [Table("Otel_Rezervasyonlar")]
    public class Otel_Rezervasyonlar
    {
        [Key]
        public string RezervasyonId { get; set; }
        public string UserID { get; set; }
        public string OtelID { get; set; }

       
        public string OtelName { get; set; }
        public DateTime Giris_tarihi { get; set; }
        public DateTime Cıkıs_tarihi { get; set; }
        public string  Rezervasyondurumu{ get; set; }

        public string  Oda_no { get; set; }




    }
}
