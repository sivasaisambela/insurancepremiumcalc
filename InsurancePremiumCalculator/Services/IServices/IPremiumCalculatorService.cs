using InsurancePremiumCalculator.Models;

namespace InsurancePremiumCalculator.Services.IServices
{
    public interface IPremiumCalculatorService
    {
        decimal Calculate(PremiumCalculationRequest request);
    }
}
