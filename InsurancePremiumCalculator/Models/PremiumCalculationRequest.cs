using System.ComponentModel.DataAnnotations;

namespace InsurancePremiumCalculator.Models
{
    public class PremiumCalculationRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int AgeNextBirthday { get; set; }

        [Required]
        public string DateOfBirth { get; set; }  // mm/yyyy

        [Required]
        public string Occupation { get; set; }

        [Required]
        public decimal DeathSumInsured { get; set; }
    }
}
