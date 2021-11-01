using System;
namespace Orderio.Application.ViewModels.Orders
{
    public class StatusViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsCurrent { get; set; }
        public string Name { get; set; }
        public string NameEng { get; set; }
        public string Colour { get; set; }
        public string Description { get; set; }
    }
}