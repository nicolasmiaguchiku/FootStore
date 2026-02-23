using FootStore.Domain.Enums;
using FootStore.Domain.ValueObjects;

namespace FootStore.Domain.Entities
{
    public class OrderEntity
    {
        public Guid Id { get; set; }
        public CustomerEntity Customer { get; set; } = default!;
        public Status Status { get; set; }
        public decimal TotalPayment { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; } = [];

        public OrderEntity SetId(Guid id)
        {
            Id = id;
            return this;
        }

        public OrderEntity SetCustomer(CustomerEntity customer)
        {
            Customer = customer;
            return this;
        }

        public OrderEntity SetStatus(Status status)
        {
            Status = status;
            return this;
        }

        public OrderEntity SetTotalPayment(decimal totalPayment)
        {
            TotalPayment = totalPayment;
            return this;
        }

        public OrderEntity SetCreatedAt(DateTime createdAt)
        {
            CreatedAt = createdAt;
            return this;
        }

        public OrderEntity SetOrderItem(IEnumerable<OrderItem> orderItems)
        {
            OrderItems = orderItems;
            return this;
        }

        public Builder ToBuilder()
        {
            return new Builder
            {
                Id = Id,
                Customer = Customer,
                Status = Status,
                TotalPayment = TotalPayment,
                CreatedAt = CreatedAt,
                OrderItems = OrderItems
            };
        }

        public class Builder
        {
            public Guid Id { get; set; }
            public CustomerEntity Customer { get; set; } = default!;
            public Status Status { get; set; }
            public decimal TotalPayment { get; set; }
            public DateTime CreatedAt { get; set; }
            public IEnumerable<OrderItem> OrderItems { get; set; } = [];

            public static Builder Create() => new();

            public Builder SetId(Guid id) { Id = id; return this; }
            public Builder SetCustomer(CustomerEntity customer) { Customer = customer; return this; }
            public Builder SetStatus(Status status) { Status = status; return this; }
            public Builder SetTotalPayment(decimal totalPayment) { TotalPayment = totalPayment; return this; }
            public Builder SetCreatedAt(DateTime createdAt) { CreatedAt = createdAt; return this; }
            public Builder SetOrderItem(IEnumerable<OrderItem> orderItems) { OrderItems = orderItems; return this; }

            public OrderEntity Build()
            {
                return new OrderEntity
                {
                    Id = Id,
                    Customer = Customer,
                    Status = Status,
                    TotalPayment = TotalPayment,
                    CreatedAt = CreatedAt,
                    OrderItems = OrderItems
                };
            }
        }
    }
}