namespace SestaPaskaitaCSharp.Models
{
    public class Order
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }

        public Order() { }
        public Order(Customer customer, List<Product> products)
        {
            Customer = customer;
            Products = products;
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (Product product in Products)
            {
                total += product.Price;
            }
            return total;
        }
    }
}
