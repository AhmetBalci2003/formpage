using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace formpage.Models
{
    [Table("Otobus")]
    public class Otobus
    {
        [Key]
        public string  Otobus_Id { get; set; }
        public string Plaka { get; set; }
        public string Sofor_adı_soyadı { get; set; }
        public string  firma_adı { get; set; }


        public Otobus()
        {
            
        }

    }
}
