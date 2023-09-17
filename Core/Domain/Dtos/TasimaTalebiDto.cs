using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class TasimaTalebiDto
    {
        [Required(ErrorMessage = "Lütfen Açıklama giriniz.")]
        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Lütfen Başlangıç Noktasını giriniz.")]
        public string Baslangic { get; set; }

        [Required(ErrorMessage = "Lütfen Bitiş Noktasını giriniz.")]
        public string Bitis { get; set; }

        [Required(ErrorMessage = "Lütfen Aradaki Mesafeyi giriniz.")]
        public int Mesafe  { get; set; }

        public string? EsyaImgUrl { get; set; }

    }
}
