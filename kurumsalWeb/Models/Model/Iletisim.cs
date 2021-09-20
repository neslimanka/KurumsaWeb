using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace kurumsalWeb.Models.Model
{
    [Table("İletişim")]
    public class Iletisim
    {
        [Key]
        public int IlerisimId { get; set; }
        [StringLength(250,ErrorMessage ="250 karakter olmalıdır")]
        public string Adres { get; set; }
        [StringLength(250, ErrorMessage = "250 karakter olmalıdır")]
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Watshapp { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }


    }
}