using CoreBusiness;

namespace UseCases.CategoriesUseCases
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryId);
    }
}