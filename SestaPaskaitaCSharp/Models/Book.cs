namespace SestaPaskaitaCSharp.Models
{
    public class Book
    {
        public string Name { get; set; }
        public bool Booked { get; set; }

        public Book() { }
        public Book(string name, bool booked)
        {
            Name = name;
            Booked = booked;
        }
    }
}
