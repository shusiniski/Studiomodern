using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace studiomoderna.Models.Model
{
    [Tabel("Haqqımızda")]
    public class Haqqımızda
    {
        [Key]
        public int HaqqımızdaId { get; set; }
        [Required]
        [DisplayName("Haqqımızda Aciklama")]
        public string Aciklama { get; set; }
    }
}