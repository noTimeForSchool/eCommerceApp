using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp
{
    public class Product
    {
        private int _prodID;
        private string _prodName;
        private double _itemPrice;
        private int _stockAmount;

        private int _stockIncreaseAmount;
        private int _stockDecreaseAmount;

        public int ProdID
        {
            get => _prodID;
            set
            {
                if (value < 5 || value > 50000)
                {
                    throw new ArgumentOutOfRangeException(nameof(ProdID), "ProdID must be between 5 and 50000.");
                }
                _prodID = value;
            }
        }
      public string ProdName
        {
            get => _prodName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(ProdName), "Product name cannot be null or empty.");
                }
                _prodName = value;
            }
        }


        public int StockIncrease
        {
            get
            {
                return _stockIncreaseAmount;
            }
            set
            {
                if ((value + _stockAmount) > 500000)
                {
                    throw new ArgumentOutOfRangeException(nameof(StockIncrease), "Stock amount with the Increase must not exceed 500000");
                }
                _stockIncreaseAmount = value + _stockAmount;
                _stockAmount = _stockIncreaseAmount;
            }
        }

        public int StockDecrease
        {
            get
            {
                return _stockDecreaseAmount;
            }
            set
            {
                if ((_stockAmount - value) < 5)
                {
                    throw new ArgumentOutOfRangeException(nameof(StockDecrease), "Stock amount with the Decrease must not be less than 5");
                }

                _stockDecreaseAmount = _stockAmount - value;
                _stockAmount = _stockDecreaseAmount;
            }
        }




        public Product(int prodID, string prodName, double itemPrice, int stockAmount, int stockIncrease, int stockDecrease)
        {
            ProdID = prodID;
            ProdName = prodName;
            //ItemPrice = itemPrice;
            //StockAmount = stockAmount;

            //StockIncrease = stockIncrease;
            //StockDecrease = stockDecrease;
        }

        public double ItemPrice
        {
            get
            {
                return _itemPrice;
            }
            set
            {
                if (value < 5 || value > 5000)
                {
                    throw new ArgumentOutOfRangeException(nameof(ItemPrice), "ItemPrice must be between 5 and 5000.");
                }
                _itemPrice = value;
            }
        }
        public int StockAmount
        {
            get
            {
                return _stockAmount;
            }
            set
            {
                if (value < 5 || value > 500000)
                {
                    throw new ArgumentOutOfRangeException(nameof(StockAmount), "StockAmount must be between 5 and 500000.");
                }
                _stockAmount = value;
            }
        }


    }
}
