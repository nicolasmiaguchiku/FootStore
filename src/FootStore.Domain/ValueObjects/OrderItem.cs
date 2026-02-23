using FootStore.Domain.Entities;

namespace FootStore.Domain.ValueObjects
{
    public class OrderItem
    {
        public ProductEntity Product { get; set; } = default!;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}