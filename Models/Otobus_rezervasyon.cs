using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace formpage.Models
{
    [Table("Otobus_rezervasyon")]
    public class Otobus_rezervasyon
    {
        [Key]
        public string RezervasyonId { get; set; }
        public string  User_ID { get; set; }
        
        public string  SeferId {  get; set; }
        public string koltukno { get; set; }

        public string Rezervasyondurumu  { get; set; }

        public Otobus_rezervasyon()
        {
            
        }
    }
}
