using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace formpage.Models
{
    [Table("Seferler")]
    public class Seferler
    {
        [Key]
        public string SeferId{ get; set; }
        public string Baslangıc_sehir { get; set; }
        public string Varıs_sehri {  get; set; }
        public DateTime baslangıc_tarihi { get; set; }
        public DateTime varıs_tarihi { get; set; }
        public  string otobus_Id  { get; set; }
        public string sefer_durumu { get; set; }
        public string fiyat { get; set; }

        public bool koltuk_1 { get; set; } = false;
        public string koltuk_1user { get; set; } = "";

        public bool koltuk_2 { get; set; } = false;
        public string koltuk_2user { get; set; } = "";

        public bool koltuk_3 { get; set; } = false;
        public string koltuk_3user { get; set; } = "";

        public bool koltuk_4 { get; set; } = false;
        public string koltuk_4user { get; set; } = "";

        public bool koltuk_5 { get; set; } = false;
        public string koltuk_5user { get; set; } = "";

        public bool koltuk_6 { get; set; } = false;
        public string koltuk_6user { get; set; } = "";

        public bool koltuk_7 { get; set; } = false;
        public string koltuk_7user { get; set; } = "";

        public bool koltuk_8 { get; set; } = false;
        public string koltuk_8user { get; set; } = "";

        public bool koltuk_9 { get; set; } = false;
        public string koltuk_9user { get; set; } = "";

        public bool koltuk_10 { get; set; } = false;
        public string koltuk_10user { get; set; } = "";

        public bool koltuk_11 { get; set; } = false;
        public string koltuk_11user { get; set; } = "";

        public bool koltuk_12 { get; set; } = false;
        public string koltuk_12user { get; set; } = "";

        public bool koltuk_13 { get; set; } = false;
        public string koltuk_13user { get; set; } = "";

        public bool koltuk_14 { get; set; } = false;
        public string koltuk_14user { get; set; } = "";

        public bool koltuk_15 { get; set; } = false;
        public string koltuk_15user { get; set; } = "";

        public bool koltuk_16 { get; set; } = false;
        public string koltuk_16user { get; set; } = "";

        public bool koltuk_17 { get; set; } = false;
        public string koltuk_17user { get; set; } = "";

        public bool koltuk_18 { get; set; } = false;
        public string koltuk_18user { get; set; } = "";

        public bool koltuk_19 { get; set; } = false;
        public string koltuk_19user { get; set; } = "";

        public bool koltuk_20 { get; set; } = false;
        public string koltuk_20user { get; set; } = "";

        public bool koltuk_21 { get; set; } = false;
        public string koltuk_21user { get; set; } = "";

        public bool koltuk_22 { get; set; } = false;
        public string koltuk_22user { get; set; } = "";

        public bool koltuk_23 { get; set; } = false;
        public string koltuk_23user { get; set; } = "";

        public bool koltuk_24 { get; set; } = false;
        public string koltuk_24user { get; set; } = "";

        public bool koltuk_25 { get; set; } = false;
        public string koltuk_25user { get; set; } = "";

        public bool koltuk_26 { get; set; } = false;
        public string koltuk_26user { get; set; } = "";

        public bool koltuk_27 { get; set; } = false;
        public string koltuk_27user { get; set; } = "";

        public bool koltuk_28 { get; set; } = false;
        public string koltuk_28user { get; set; } = "";

        public bool koltuk_29 { get; set; } = false;
        public string koltuk_29user { get; set; } = "";

        public bool koltuk_30 { get; set; } = false;
        public string koltuk_30user { get; set; } = "";

        public bool koltuk_31 { get; set; } = false;
        public string koltuk_31user { get; set; } = "";

        public bool koltuk_32 { get; set; } = false;
        public string koltuk_32user { get; set; } = "";

        public bool koltuk_33 { get; set; } = false;
        public string koltuk_33user { get; set; } = "";

        public bool koltuk_34 { get; set; } = false;
        public string koltuk_34user { get; set; } = "";

        public bool koltuk_35 { get; set; } = false;
        public string koltuk_35user { get; set; } = "";

        public bool koltuk_36 { get; set; } = false;
        public string koltuk_36user { get; set; } = "";

        public bool koltuk_37 { get; set; } = false;
        public string koltuk_37user { get; set; } = "";

        public bool koltuk_38 { get; set; } = false;
        public string koltuk_38user { get; set; } = "";

        public bool koltuk_39 { get; set; } = false;
        public string koltuk_39user { get; set; } = "";

        public bool koltuk_40 { get; set; } = false;
        public string koltuk_40user { get; set; } = "";

        public Seferler()
        {
            
        }
    }
}
