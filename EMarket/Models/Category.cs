using System.Data;

namespace EMarket.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int? RootId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedData { get; set; }
    }
}
