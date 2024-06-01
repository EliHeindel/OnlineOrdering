using System.Collections.Generic;
using System.Text;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            this.products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;

            foreach (var product in products)
            {
                totalCost += product.TotalCost();
            }

            decimal shippingCost = customer.IsInUSA() ? 5m : 35m;
            return totalCost + shippingCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder packingLabel = new StringBuilder();

            foreach (var product in products)
            {
                packingLabel.AppendLine($"{product.GetName()} ({product.GetProductId()})");
            }

            return packingLabel.ToString();
        }

        public string GetShippingLabel()
        {
            return $"{customer.GetName()}\n{customer.GetAddress()}";
        }
    }
}
