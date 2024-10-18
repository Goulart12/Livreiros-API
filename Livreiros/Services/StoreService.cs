using Livreiros.Data;
using Livreiros.InputModels;
using Livreiros.Models;

namespace Livreiros.Services;

public class StoreService
{
    private readonly StoreDbContext _storeDbContext;

    public StoreService(StoreDbContext storeDbContext)
    {
        _storeDbContext = storeDbContext;
    }

    public async Task<StoreModel> CreateStore(StoreInputModel inputModel)
    {
        var store = new StoreModel
        {
            Name = inputModel.Name,
            TypeOfStore = inputModel.TypeOfStore,
            State = inputModel.State,
            City = inputModel.City,
            Address = inputModel.Address,
            IsAlwaysAvailable = inputModel.IsAlwaysAvailable,
            FromDate = inputModel.FromDate,
            ToDate = inputModel.ToDate,
            BusinessHours = inputModel.BusinessHours,
        };

        _storeDbContext.Add(store);

        await _storeDbContext.SaveChangesAsync();

        return store;
    }
}