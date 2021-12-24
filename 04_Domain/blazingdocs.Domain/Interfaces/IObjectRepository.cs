using blazingdocs.Domain.Categories;
using blazingdocs.Domain.VirtualObjects;
using System.Threading.Tasks;

namespace blazingdocs.Domain
{
    public interface IObjectRepository
    {
        Task SaveVirtualObjectAsync(VirtualObject virtualObject);

        Task SaveCategoryAsync(Category category);
    }
}
