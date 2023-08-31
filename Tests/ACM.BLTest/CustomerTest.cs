using ACM.BL;

namespace ACM.BLTest;

[TestClass]
public class CustomerTest
{
    [TestMethod]
    public void FullNameTestValid()
    {
        //Arrange 
        Customer customer = new Customer()
        {
            FirstName = "Gee",
            LastName = "Shek"
            // customer.FirstName = "Gee";
            // customer.LastName = "Shek";
        };

        string expected = "Shek, Gee";
        
        //Act
        string actual = customer.FullName;
        
        //Assert
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void FullNameFirstNameEmpty()
    {
        //Arrange 
        Customer customer = new Customer()
        {
            FirstName = "Gee",
            // LastName = "Shek"
            // customer.FirstName = "Gee";
            // customer.LastName = "Shek";
        };

        string expected = "Gee";
        
        //Act
        string actual = customer.FullName;
        
        //Assert
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public voidFullNameLastNameEmptyTest()
    {
        //Arrange 
        Customer customer = new Customer()
        {
            // FirstName = "Gee",
            LastName = "Shek"
            // customer.FirstName = "Gee";
            // customer.LastName = "Shek";
        };

        string expected = "Shek";
        
        //Act
        string actual = customer.FullName;
        
        //Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void StaticTest()
    {
        //Arrange
        var c1 = new Customer();
        c1.FirstName = "Bilbo";
        Customer.InstanceCount++;
        var c2 = new Customer();
        c1.FirstName = "Frodo";
        Customer.InstanceCount++;
        var c3 = new Customer();
        c1.FirstName = "Rosie";
        Customer.InstanceCount++;
        //Act
        
        
        //Assert
        Assert.AreEqual(3,Customer.InstanceCount);
    }

}