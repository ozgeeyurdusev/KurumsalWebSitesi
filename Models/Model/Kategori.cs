using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWebSitesi.Models.Model
{
    [Table("Kategori")]
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        [Required,StringLength(50,ErrorMessage ="50 karakter olmalıdır")]
        [DisplayName("Kategori Ad")]
        public string KategoriAd { get; set; }
        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}