using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace studiomoderna.Models.Model
{
    [Table("Kimlik")]
    public class Kimlik
    {
        [Key]
        public int KimlikId { get; set; }
        [DisplayName("Sayt Basliq")]
        [Required,StringLength(100,ErrorMessage ="100 Karakter olmalidir")]
        public string Title { get; set; }
        [DisplayName("Acar Sozler")]
        [Required, StringLength(200, ErrorMessage = "200 Karakter olmalidir")]
        public string Keywords { get; set; }
        [DisplayName("Sayt Aciklama")]
        [Required, StringLength(300, ErrorMessage = "300 Karakter olmalidir")]
        public string Description { get; set; }
        [DisplayName("Sayt Logo")]
        public string LogoURL { get; set; }
        [DisplayName("Sayt Unvan")]
        public string Unvan { get; set; }
    }
}