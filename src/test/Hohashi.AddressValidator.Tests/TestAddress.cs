namespace Hohashi.AddressValidator.Tests
{
    using System.Collections.Generic;
    using System.Configuration;

    using NUnit.Framework;

    public class TestAddress
    {
        private readonly string apiUrl = ConfigurationManager.AppSettings["ApiUrl"];

        private readonly string authId = ConfigurationManager.AppSettings["AuthenticationId"];

        private readonly string authToken = ConfigurationManager.AppSettings["AuthenticationToken"];

        [Test]
        public void ReturnCandidateList()
        {
            // Arrange
            var addressValidator = new AddressValidator(this.apiUrl, this.authId, this.authToken);
            var addressToValidate = new Address { Street = "315 Bowery", City = "New York", State = "NY", Zip = string.Empty };

            // Act
            List<CandidateAddress> candidateAddresses = addressValidator.Validate(addressToValidate);

            // Assert
            Assert.That(candidateAddresses.Count > 0);
        }
    }
}