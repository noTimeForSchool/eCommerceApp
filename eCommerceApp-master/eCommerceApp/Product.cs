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

        

        


        public Product(int prodID, string prodName, double itemPrice, int stockAmount, int stockIncrease, int stockDecrease)
        {
            ProdID = prodID;
            ProdName = prodName;
            //ItemPrice = itemPrice;
            //StockAmount = stockAmount;

            //StockIncrease = stockIncrease;
            //StockDecrease = stockDecrease;
        }


    }
}
