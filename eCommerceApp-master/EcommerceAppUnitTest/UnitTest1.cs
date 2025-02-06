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

        [TestCase(4)]
        [TestCase(5001)]
        /// value of 4 and 5001 is out of range
        public void ItemPrice_ShouldThrowException_WhenOutOfRange(double itemPrice)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _product.ItemPrice = itemPrice);
            StringAssert.Contains("ItemPrice must be between 5 and 5000.", ex.Message);
        }


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

        [TestCase(4)]
        [TestCase(500001)]
        /// value of 4 and 500001 is out of range
        public void StockAmount_ShouldThrowException_WhenOutOfRange(int stockAmount)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _product.StockAmount = stockAmount);
            StringAssert.Contains("StockAmount must be between 5 and 500000.", ex.Message);
        }

        [TestCase(5)] // An increase of 5 + Stock value [10], is in range.
        [TestCase(1000)] // An increase of 10000 + Stock value [10], is in range.
        [TestCase(499990)] // An increase of 499990 + Stock value [10], is in range.
        public void StockAmountIncrease_ShouldBeWithinValidRange(int increaseAmount)
        {
            _product.StockIncrease = increaseAmount;

            Assert.That(_product.StockIncrease, Is.EqualTo(increaseAmount + 10));
        }



        [TestCase(500000)]// An increase of 500000 + Stock value [10], is out of range.
        [TestCase(499991)]// An increase of 499991 + Stock value [10], is out of range.
        [TestCase(510000)]// An increase of 510000 + Stock value [10], is out of range.
        // [TestCase(10000)] // An increase of 10000 + + Stock value [10], is in range. As Such will Fail 
        public void StockAmountIncrease_ShouldThrowException(int increaseAmount)
        {
           
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _product.StockIncrease = increaseAmount);
            StringAssert.Contains("Stock amount with the Increase must not exceed 500000", ex.Message);
        }


        [TestCase(5)] // A Decrease of Stock value [10] - 5, is in range.
        [TestCase(4)] // A Decrease of Stock value [10] - 4, is in range.
        [TestCase(3)] // A Decrease of Stock value [10] - 3, is in range.
        //[TestCase(6)]// A Decrease of Stock value [10] - 6, is out of range.
        public void StockAmountDecrease_ShouldBeWithinValidRange(int decreaseAmount)
        {
            _product.StockDecrease = decreaseAmount;

            Assert.That(_product.StockDecrease, Is.EqualTo(10 - decreaseAmount));
        }

        [TestCase(6)]// A Decrease of Stock value [10] - 6, is out of range.
        [TestCase(7)]// A Decrease of Stock value [10] - 7, is out of range.
        [TestCase(8)]// A Decrease of Stock value [10] - 8, is out of range.
        public void StockAmountDecrease_ShouldThrowException(int decreaseAmount)
        {

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _product.StockDecrease = decreaseAmount);
            StringAssert.Contains("Stock amount with the Decrease must not be less than 5", ex.Message);
        }



    }
}