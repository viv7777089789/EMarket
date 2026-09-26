namespace EMarket.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public int GoodId { get; set; }
        public decimal GoodPrice { get; set; }
        public int Quantity { get; set; }
        public decimal FullPrice { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
