using System;
using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }

        private string _productName;

        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set { _productName = value; }
        }

        public int ProductId { get; private set; }
        public DateTime OrderDate { get; set; }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString() => ProductName;
    }
}