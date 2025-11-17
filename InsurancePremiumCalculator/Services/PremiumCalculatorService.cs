using InsurancePremiumCalculator.Models;
using InsurancePremiumCalculator.Services.IServices;

namespace InsurancePremiumCalculator.Services
{
    public class PremiumCalculatorService : IPremiumCalculatorService
    {
        private readonly IOccupationRatingService _ratingService;

        public PremiumCalculatorService(IOccupationRatingService ratingService)
        {
            _ratingService = ratingService;
        }
        public decimal Calculate(PremiumCalculationRequest request)
        {
            var factor = _ratingService.GetRatingFactor(request.Occupation);

            var premium = ((request.DeathSumInsured * factor * request.AgeNextBirthday) / 1000m) * 12m;

            return Math.Round(premium, 2);
        }
    }
}
