using InsurancePremiumCalculator.Services.IServices;

namespace InsurancePremiumCalculator.Services
{
    public class OccupationRatingService : IOccupationRatingService
    {
        private readonly Dictionary<string, decimal> _factors = new()
        {
            {"Cleaner", 11.50m},
            {"Doctor", 1.50m},
            {"Author", 2.25m},
            {"Farmer", 31.75m},
            {"Mechanic", 31.75m},
            {"Florist", 11.50m},
            {"Other", 31.75m}
        };
        public decimal GetRatingFactor(string occupation)
        {
            if (string.IsNullOrWhiteSpace(occupation))
                return 0;


            switch (occupation.ToLower().Trim())
            {
                case "cleaner":
                    return 11.50m;

                case "doctor":
                    return 1.50m;

                case "author":
                    return 2.25m;

                case "farmer":
                case "mechanic":
                case "other":
                    return 31.75m;

                case "florist":
                    return 11.50m;

                default:
                    return 0;
            }
        }
    }
}
