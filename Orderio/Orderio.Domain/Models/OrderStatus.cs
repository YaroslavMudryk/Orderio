namespace Orderio.Domain.Models
{
    public class OrderStatus : BaseModel<long>
    {
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public long OrderId { get; set; }
        public Order Order { get; set; }
    }
}