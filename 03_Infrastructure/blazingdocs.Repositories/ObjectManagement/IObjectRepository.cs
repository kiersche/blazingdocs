using blazingdocs.Domain.Categories;
using blazingdocs.Domain.VirtualObjects;
using System.Threading.Tasks;

namespace blazingdocs.Repositories.ObjectManagement
{
    public interface IObjectRepository
    {
        Task SaveVirtualObjectAsync(VirtualObject virtualObject);

        Task SaveCategoryAsync(Category category);
    }
}
