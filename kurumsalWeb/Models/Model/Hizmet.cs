﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace kurumsalWeb.Models.Model
{
    [Table("Hizmet")]
    public class Hizmet
    {
        [Key]
        public int HizmetId { get; set; }
        [Required,StringLength(150,ErrorMessage ="150 karakter olmalıdır")]
        [DisplayName("Hizmet Başlık")]
        public string Baslik  { get; set; }
        [DisplayName("Hizmet Açılama")]
        public string Aciklama { get; set; }
        [DisplayName("Hizmet Resim")]
        public string ResimURL { get; set; }
    }
}