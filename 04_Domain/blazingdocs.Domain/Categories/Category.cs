using blazingdocs.Domain.VirtualObjects;
using System.Collections.Generic;

namespace blazingdocs.Domain.Categories
{
    public record Category(
        CategoryId CategoryId,
        CategoryName Name,
        IEnumerable<VirtualObject> Objects);
}
