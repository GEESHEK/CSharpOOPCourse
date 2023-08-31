using ACM.BL;

namespace ACM.BLTest;

[TestClass]
public class CustomerRepositoryTest
{
    [TestMethod]
    public void RetrieveValid()
    {
        var customerRepository = new CustomerRepository();
        var expected = new Customer(1)
        {
            EmailAddress = "fbaagins@hobbiton.me",
            FirstName = "Frodo",
            LastName = "Baggins"
        };

        var actual = customerRepository.Retrieve(1);
        
        Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        Assert.AreEqual(expected.FirstName, actual.FirstName);
        Assert.AreEqual(expected.LastName, actual.LastName);
        Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
    }
}