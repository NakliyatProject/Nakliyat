using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos
{
    public class EkipDto
    {
        [Required(ErrorMessage = "EkipName is required.")]
        public string EkipName { get; set; }

        [Required(ErrorMessage = "AracName is required.")]
        public string AracName { get; set; }

        [Required(ErrorMessage = "AracPlakasi is required.")]
        public string AracPlakasi { get; set; }

        [Required(ErrorMessage = "EkipLead is required.")]
        public string EkipLead { get; set; }

        [Required(ErrorMessage = "AracImgUrl is required.")]
        public string? AracImgUrl { get; set; }

        [Required(ErrorMessage = "EkipTelNo is required.")]
        public string EkipTelNo { get; set; }

    }

}
