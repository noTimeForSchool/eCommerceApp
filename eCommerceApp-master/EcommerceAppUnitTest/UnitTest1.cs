using eCommerceApp;
namespace EcommerceAppUnitTest
{
    public class Tests
    {
        private Product _product;

        [SetUp]
        public void Setup()
        {
            _product = new Product(101, "Laptop", 999.99, 10, 0, 0);
        }
        

        [TestCase(10)]
        [TestCase(2000)]
        [TestCase(50000)]
        public void ProdID_ShouldBeWithinValidRange(int prodID)
        {
            _product.ProdID = prodID;

            Assert.That(_product.ProdID, Is.EqualTo(prodID));
        }

        [TestCase("Smartphone")]   
        [TestCase("Bottle Water")]   
        [TestCase("Gaming Console")] 
        public void ProdName_ShouldAcceptValidNames(string prodName)
        {
           
            _product.ProdName = prodName;

            Assert.That(_product.ProdName, Is.EqualTo(prodName));

        }

    }
}