using InsurancePremiumCalculator.Models;
using InsurancePremiumCalculator.Services;

namespace PremiumCalculator.Tests
{
    public class PremiumCalculatorServiceTests
    {
       
            [Fact]
            public void Calculate_ShouldReturnCorrectPremium()
            {
                // Arrange
                var ratingService = new OccupationRatingService();
                var service = new PremiumCalculatorService(ratingService);

                var request = new PremiumCalculationRequest
                {
                    Name = "John",
                    AgeNextBirthday = 25,
                    DateOfBirth = "05/1999",
                    Occupation = "Doctor",
                    DeathSumInsured = 1000000
                };

                // Act
                var premium = service.Calculate(request);

                // Assert
                // (1000000 * 1.5 * 25)/1000 * 12 = 450000
                Assert.Equal(450000, premium);
            }
        
    }
}
