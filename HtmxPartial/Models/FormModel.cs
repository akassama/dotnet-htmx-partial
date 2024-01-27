using System.ComponentModel.DataAnnotations;

namespace HtmxPartial.Models
{
    public class FormModel
    {
        [Key]
        public Guid FormId { get; set; }

        [Required]
        [Display(Name = "Form Input")]
        public string FormInput { get; set; } = null!;

        [Required]
        [Display(Name = "Select Input")]
        public string SelectInput { get; set; } = null!;

        [Display(Name = "Partial One")]
        public string? PartialOne { get; set; } = string.Empty;

        [Display(Name = "Partial Two")]
        public string? PartialTwo { get; set; } = string.Empty;
    }
}
