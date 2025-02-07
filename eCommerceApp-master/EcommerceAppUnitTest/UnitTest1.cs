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

        // Test cases for ProdID
        [TestCase(10)]
        [TestCase(2000)]
        [TestCase(50000)]
        public void ProdID_ShouldBeWithinValidRange(int prodID)
        {
            _product.ProdID = prodID;

            Assert.That(_product.ProdID, Is.EqualTo(prodID));
        }

        // Test cases for ProdName
        [TestCase("Smartphone")]   
        [TestCase("Bottle Water")]   
        [TestCase("Gaming Console")] 
        public void ProdName_ShouldAcceptValidNames(string prodName)
        {
           
            _product.ProdName = prodName;

            Assert.That(_product.ProdName, Is.EqualTo(prodName));

        }

        // Test cases for StockIncrease
        [TestCase(5)] 
        [TestCase(1000)] 
        [TestCase(499990)] 
        public void StockAmountIncrease_ShouldBeWithinValidRange(int increaseAmount)
        {
            _product.StockIncrease = increaseAmount;

            Assert.That(_product.StockIncrease, Is.EqualTo(increaseAmount + 10));
        }

        // Test cases for StockDecrease
        [TestCase(5)] 
        [TestCase(4)]
        [TestCase(3)] 
                     
        public void StockAmountDecrease_ShouldBeWithinValidRange(int decreaseAmount)
        {
            _product.StockDecrease = decreaseAmount;

            Assert.That(_product.StockDecrease, Is.EqualTo(10 - decreaseAmount));
        }

        // Test cases for ItemPrice
        [TestCase(5)]
        [TestCase(1000)]
        [TestCase(5000)]
        /// value of 5 and 5000 is in the margin of the range
        /// value of 1000 is inside the range
        public void ItemPrice_ShouldBeWithinValidRange(double itemPrice)
        {
            _product.ItemPrice = itemPrice;
            Assert.That(_product.ItemPrice, Is.EqualTo(itemPrice));
        }

        // Test cases for StockAmount
        [TestCase(5)]
        [TestCase(10000)]
        [TestCase(500000)]
        /// value of 5 and 500000 is in the margin of the range
        /// value of 10000 is inside the range
        public void StockAmount_ShouldBeWithinValidRange(int stockAmount)
        {
            _product.StockAmount = stockAmount;

            Assert.That(_product.StockAmount, Is.EqualTo(stockAmount));
        }
    }
}