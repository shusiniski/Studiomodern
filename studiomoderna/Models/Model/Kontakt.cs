using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace studiomoderna.Models.Model
{
    [Tabel("Kontakt")]
    public class Kontakt
    {
        [Key]
        public int KontaktId { get; set; }
        [StringLength(250,ErrorMessage ="250 Karakter olmalidir")]
        public string Adres{ get; set; }
        [StringLength(250, ErrorMessage = "250 Karakter olmalidir")]
        public string Telefon{ get; set; }
        public string Fax { get; set; }
        public string Whatsapp { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
    }
}