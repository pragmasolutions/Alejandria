using System.Collections.Generic;
using System.Linq;

namespace Alejandria.Data.Helpers
{
    public class PagedResultList<T>
    {
        public PagedMetadata PagedMetadata { get; set; }

        public IQueryable<T> Entities { get; set; }
    }
}
