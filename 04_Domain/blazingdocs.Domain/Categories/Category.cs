using blazingdocs.Domain.VirtualObjects;
using System.Collections.Generic;

namespace blazingdocs.Domain
{
    public record Category(
        CategoryId CategoryId,
        CategoryName Name,
        IEnumerable<VirtualObject> Objects);
}
