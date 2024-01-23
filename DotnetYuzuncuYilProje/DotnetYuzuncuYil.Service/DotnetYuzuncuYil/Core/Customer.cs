namespace DotnetYuzuncuYil.Core
{
    internal class Customer : Models.Customer
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string CustomerName { get; set; }
        public int SellerId { get; set; }
    }
}