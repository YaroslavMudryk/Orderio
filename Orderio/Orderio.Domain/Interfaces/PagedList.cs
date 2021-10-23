using System.Collections.Generic;

namespace Orderio.Domain.Interfaces
{
    public class PagedList<TEntity>
    {
        public PagedList(IList<TEntity> items, int totalCount, int page)
        {
            Items = items;
            TotalCount = totalCount;
            Page = page;
        }
        public IList<TEntity> Items { get; }
        public int TotalCount { get; }
        public int Page { get; set; }
    }
}
