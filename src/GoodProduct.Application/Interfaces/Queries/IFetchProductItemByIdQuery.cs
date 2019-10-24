using GoodProduct.Application.Interfaces.Errors;
using GoodProduct.Domain;
using LanguageExt;

namespace GoodProduct.Application.Interfaces.Queries
{
    public interface IFetchProductItemByIdQuery
    {
        EitherAsync<IFetchProductItemByIdQueryError, ProductItem> Execute(string id);
    }
}