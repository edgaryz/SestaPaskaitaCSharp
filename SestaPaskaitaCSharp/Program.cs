using SestaPaskaitaCSharp.Models;

namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* TASK 1 */
            Console.WriteLine("TASK 1");
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("Petka", 50));
            studentList.Add(new Student("Russel", 70));
            studentList.Add(new Student("John", 96));
            studentList.Add(new Student("Rose", 25));
            studentList.Add(new Student("Alex", 49));

            foreach (Student student in studentList)
            {
                if (student.Grade < 50)
                {
                    Console.WriteLine(student.Name + " needs to retake exam because the score was " + student.Grade);
                }
            }

            /* TASK 2 */
            Console.WriteLine("TASK 2");
            List<Book> booking = new List<Book>();
            booking.Add(new Book("Van Helsing", true));
            booking.Add(new Book("Witcher", true));
            booking.Add(new Book("Big John", false));
            booking.Add(new Book("Star Wars", true));
            booking.Add(new Book("Hangover", false));

            foreach (Book book in booking)
            {
                if (book.Booked)
                {
                    Console.WriteLine(book.Name + " is booked");
                }
            }

            /* TASK 3 */
            Console.WriteLine("TASK 3");
            List<Product> shoppingList = new List<Product>();
            shoppingList.Add(new Product("Eggs", 1.99));
            shoppingList.Add(new Product("Cheese", 3.68));
            shoppingList.Add(new Product("Noodles", 0.99));
            shoppingList.Add(new Product("Spices", 0.15));
            shoppingList.Add(new Product("Chicken", 5.99));

            double shoppingTotal = 0;
            foreach (Product product in shoppingList)
            {
                shoppingTotal += product.Price;
            }
            Console.WriteLine(shoppingTotal);

            /* TASK 4 */
            Console.WriteLine("TASK 4");
            Customer alex = new Customer("Alex");
            Order order1 = new Order();
            List<Product> productList1 = new List<Product>();
            productList1.Add(new Product("Cheese", 1.99));
            productList1.Add(new Product("Sauce", 0.99));
            productList1.Add(new Product("Spaghetti", 1.50));
            productList1.Add(new Product("Hot Dog", 2.99));
            order1 = new Order(alex, productList1);

            Order order2 = new Order();
            List<Product> productList2 = new List<Product>();
            productList2.Add(new Product("Cheese", 1.99));
            productList2.Add(new Product("Sauce", 0.99));
            productList2.Add(new Product("Spaghetti", 1.50));
            productList2.Add(new Product("Hot Dog", 2.99));
            productList2.Add(new Product("Vegetable Mix", 0.99));
            order2 = (new Order(new Customer("John"), productList2));

            Order order3 = new Order();
            List<Product> productList3 = new List<Product>();
            productList3.Add(new Product("Sauce", 0.99));
            productList3.Add(new Product("Spaghetti", 1.50));
            productList3.Add(new Product("Hot Dog", 2.99));
            order3 = (new Order(new Customer("Chris"), productList3));

            List<Order> allOrders = new List<Order>();
            allOrders.Add(order1);
            allOrders.Add(order2);
            allOrders.Add(order3);

            double total = 0;
            foreach (var order in allOrders)
            {
                total += order.GetTotalPrice();
                Console.WriteLine(order.Customer.Name + " " + Math.Round(order.GetTotalPrice(), 2));
            }

            Console.WriteLine(Math.Round(total, 2));

        }
    }
}