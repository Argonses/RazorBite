namespace RazorBite.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int NumberOfGuests { get; set; } 
        public string Description { get; set; } = string.Empty;
    } 
}
