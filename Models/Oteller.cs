using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace formpage.Models
{
    [Table("Oteller")]
    public class Oteller
    {
        [Key]
        public int OtelID { get; set; }
        public string OtelName { get; set; }
        public string sehir { get; set; }
        public string fiyat { get; set; }

        public bool Oda_no1 { get; set; } = false;
        public DateTime? No_1_giris { get; set; } = null;
        public DateTime? No_1_cıkıs { get; set; } = null;
        public string Oda_no1_user { get; set; } = "";

        public bool Oda_no2 { get; set; } = false;
        public DateTime? No_2_giris { get; set; } = null;
        public DateTime? No_2_cıkıs { get; set; } = null;
        public string Oda_no2_user { get; set; } = "";

        public bool Oda_no3 { get; set; } = false;
        public DateTime? No_3_giris { get; set; } = null;
        public DateTime? No_3_cıkıs { get; set; } = null;
        public string Oda_no3_user { get; set; } = "";

        public bool Oda_no4 { get; set; } = false;
        public DateTime? No_4_giris { get; set; } = null;
        public DateTime? No_4_cıkıs { get; set; } = null;
        public string Oda_no4_user { get; set; } = "";

        public bool Oda_no5 { get; set; } = false;
        public DateTime? No_5_giris { get; set; } = null;
        public DateTime? No_5_cıkıs { get; set; } = null;
        public string Oda_no5_user { get; set; } = "";

        public bool Oda_no6 { get; set; } = false;
        public DateTime? No_6_giris { get; set; } = null;
        public DateTime? No_6_cıkıs { get; set; } = null;
        public string Oda_no6_user { get; set; } = "";

        public bool Oda_no7 { get; set; } = false;
        public DateTime? No_7_giris { get; set; } = null;
        public DateTime? No_7_cıkıs { get; set; } = null;
        public string Oda_no7_user { get; set; } = "";

        public bool Oda_no8 { get; set; } = false;
        public DateTime? No_8_giris { get; set; } = null;
        public DateTime? No_8_cıkıs { get; set; } = null;
        public string Oda_no8_user { get; set; } = "";

        public bool Oda_no9 { get; set; } = false;
        public DateTime? No_9_giris { get; set; } = null;
        public DateTime? No_9_cıkıs { get; set; } = null;
        public string Oda_no9_user { get; set; } = "";

        public bool Oda_no10 { get; set; } = false;
        public DateTime? No_10_giris { get; set; } = null;
        public DateTime? No_10_cıkıs { get; set; } = null;
        public string Oda_no10_user { get; set; } = "";

        public bool Oda_no11 { get; set; } = false;
        public DateTime? No_11_giris { get; set; } = null;
        public DateTime? No_11_cıkıs { get; set; } = null;
        public string Oda_no11_user { get; set; } = "";

        public bool Oda_no12 { get; set; } = false;
        public DateTime? No_12_giris { get; set; } = null;
        public DateTime? No_12_cıkıs { get; set; } = null;
        public string Oda_no12_user { get; set; } = "";

        public bool Oda_no13 { get; set; } = false;
        public DateTime? No_13_giris { get; set; } = null;
        public DateTime? No_13_cıkıs { get; set; } = null;
        public string Oda_no13_user { get; set; } = "";

        public bool Oda_no14 { get; set; } = false;
        public DateTime? No_14_giris { get; set; } = null;
        public DateTime? No_14_cıkıs { get; set; } = null;
        public string Oda_no14_user { get; set; } = "";

        public bool Oda_no15 { get; set; } = false;
        public DateTime? No_15_giris { get; set; } = null;
        public DateTime? No_15_cıkıs { get; set; } = null;
        public string Oda_no15_user { get; set; } = "";

        public bool Oda_no16 { get; set; } = false;
        public DateTime? No_16_giris { get; set; } = null;
        public DateTime? No_16_cıkıs { get; set; } = null;
        public string Oda_no16_user { get; set; } = "";

        public bool Oda_no17 { get; set; } = false;
        public DateTime? No_17_giris { get; set; } = null;
        public DateTime? No_17_cıkıs { get; set; } = null;
        public string Oda_no17_user { get; set; } = "";

        public bool Oda_no18 { get; set; } = false;
        public DateTime? No_18_giris { get; set; } = null;
        public DateTime? No_18_cıkıs { get; set; } = null;
        public string Oda_no18_user { get; set; } = "";

        public bool Oda_no19 { get; set; } = false;
        public DateTime? No_19_giris { get; set; } = null;
        public DateTime? No_19_cıkıs { get; set; } = null;
        public string Oda_no19_user { get; set; } = "";

        public bool Oda_no20 { get; set; } = false;
        public DateTime? No_20_giris { get; set; } = null;
        public DateTime? No_20_cıkıs { get; set; } = null;
        public string Oda_no20_user { get; set; } = "";



        public Oteller()
        {
            
        }


    }
}
