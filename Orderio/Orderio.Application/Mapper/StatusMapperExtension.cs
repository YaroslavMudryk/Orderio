using Orderio.Application.ViewModels.Orders;
using Orderio.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Orderio.Application.Mapper
{
    public static class StatusMapperExtension
    {
        public static List<StatusViewModel> ToStatusesView(this List<OrderStatus> orderStatus)
        {
            if (orderStatus == null || orderStatus.Count == 0)
                return null;
            return orderStatus.Where(x => x.Status != null).Select(x => new StatusViewModel
            {
                Id = x.Status.Id,
                Name = x.Status.Name,
                CreatedAt = x.CreatedAt,
                Colour = x.Status.Colour,
                Description = x.Status.Description,
                NameEng = x.Status.NameEng
            }).ToList();
        }

        public static StatusShortViewModel ToCurrentStatus(this List<OrderStatus> orderStatuses, int currentId)
        {
            if (orderStatuses == null || orderStatuses.Count == 0)
                return null;
            return orderStatuses.Select(x => x.Status).FirstOrDefault(x => x.Id == currentId).ToShortStatusView();
        }

        public static StatusShortViewModel ToShortStatusView(this Status status)
        {
            if (status == null)
                return null;
            return new StatusShortViewModel
            {
                Name = status.Name,
                Colour = status.Colour,
            };
        }
    }
}