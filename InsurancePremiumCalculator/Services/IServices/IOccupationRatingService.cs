namespace InsurancePremiumCalculator.Services.IServices
{
    public interface IOccupationRatingService
    {
        decimal GetRatingFactor(string occupation);
    }
}
