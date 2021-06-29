using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWebSitesi.Models.Model
{
    [Table("Slider")]
    public class Slider
    {
        [Key]
        public int SliderId { get; set; }
        [DisplayName("Slider Başlık"),StringLength(30,ErrorMessage ="Max.30 karakter olmalı")]
        public string Baslik { get; set; }
        [DisplayName("Slider Açıklama"), StringLength(150, ErrorMessage = "Max.150 karakter olmalı")]
        public string Aciklama { get; set; }
        [DisplayName("Slider Resim"), StringLength(250)]
        public string ResimURL { get; set; }
    }
}